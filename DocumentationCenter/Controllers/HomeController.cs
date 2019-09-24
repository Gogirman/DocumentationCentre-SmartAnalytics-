using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DocumentationCenter.Models;
using DataProvider.Entities;
using System.IO;
using DataProvider;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace DocumentationCenter.Controllers
{
    public class HomeController : Controller
    {
        private EFDBContext _context;

        public HomeController(EFDBContext context)
        {
            _context = context;
        }
        //Метод вывода всех каталогов
        public IActionResult Index()
        {
            var Files = new List<AbstractFile>();
            foreach (var doc in _context.Docs)
            {
                if (doc.Name != null)
                {
                    if (doc.Name.Contains("docx"))
                    {
                        Files.Add(new DocumentWord(doc.Id, doc.Name, doc.ParentId, doc.Annotation, doc.FileDocument));
                        continue;
                    }
                    else if (doc.Name.Contains("xlsx"))
                    {
                        Files.Add(new DocumentExcel(doc.Id, doc.Name, doc.ParentId, doc.Annotation, doc.FileDocument));
                        continue;
                    }
                    else
                    {
                        Files.Add(new Folder(doc.Id, doc.Name, doc.ParentId, doc.Annotation));
                        continue;
                    }
                }
            }
            var evm = new DocumentViewModel();
            evm.Files = Files;
            return View(evm);
        
        }
        //Метод добавления файла
        [HttpPost]
        public IActionResult AddFile(FileViewModel fileViewModel)
        {

            Docs document = new Docs() { Annotation = fileViewModel.Annotation};
            if (fileViewModel.FileDocument != null &&
                        (fileViewModel.FileDocument.FileName.Contains("docx") ||
                        fileViewModel.FileDocument.FileName.Contains("xlsx")))
            {
                byte[] docData = null;

                using (var binaryReader = new BinaryReader(fileViewModel.FileDocument.OpenReadStream()))
                {
                    docData = binaryReader.ReadBytes((int)fileViewModel.FileDocument.Length);   
                }

                document.FileDocument = docData;
                document.Name = fileViewModel.FileDocument.FileName;
                if (fileViewModel.MasterGuid != Guid.Empty)
                    document.ParentId = fileViewModel.MasterGuid;
                _context.Docs.Add(document);
                _context.SaveChanges();
            }


            return RedirectToAction("Index");
        }
        //Метод добавления каталога
        [HttpPost]
        public IActionResult AddFolder(FileViewModel fileViewModel)
        {

            Docs document = new Docs() { Annotation = fileViewModel.Annotation };

            if (fileViewModel.Name != null)
            {
                document.Name = fileViewModel.Name;
                _context.Docs.Add(document);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        //Метод открытия каталога
        [HttpPost]
        public IActionResult GetFolder(string primarykey)
        {
            var Files = new List<AbstractFile>();
            Guid id = new Guid(primarykey);
            var files2 = _context.Docs.Where(d => d.ParentId == id).ToList();
            if (files2.Count() != 0)
                foreach (var doc in files2)
                    if (doc.Name != null)
                    {
                        if (doc.Name.Contains("docx"))
                        {
                            Files.Add(new DocumentWord(doc.Id, doc.Name, doc.ParentId, doc.Annotation, doc.FileDocument));
                            continue;
                        }
                        else if (doc.Name.Contains("xlsx"))
                        {
                            Files.Add(new DocumentExcel(doc.Id, doc.Name, doc.ParentId, doc.Annotation, doc.FileDocument));
                            continue;
                        }
                    }

            JsonResult json = new JsonResult(Files);
            return json;


        }
        //Метод удаления объекта
        [HttpPost]
        public IActionResult Delete(string parametre)
        {
            Guid id = new Guid(parametre);
            var file = _context.Docs.FirstOrDefault(d => d.Id == id);
            var childFiles = _context.Docs.Where(d => d.ParentId == file.Id);
            if (file != null)
            {
                foreach (var child in childFiles)
                {
                    _context.Docs.Remove(child);
                }
                _context.Docs.Remove(file);
            }
            _context.SaveChangesAsync();

            JsonResult json = new JsonResult(parametre);
            return json;
        }
        //Метод выгрузки файла
        [HttpPost]
        public IActionResult Download(string primarykey)
        {
            var Files = new List<AbstractFile>();
            Guid id = new Guid(primarykey);
            var doc = _context.Docs.FirstOrDefault(d => d.Id == id);
            if (doc.Name.Contains("docx"))
            {
                Files.Add(new DocumentWord(doc.Id, doc.Name, doc.ParentId, doc.Annotation, doc.FileDocument));
                
            }
            else if (doc.Name.Contains("xlsx"))
            {
                Files.Add(new DocumentExcel(doc.Id, doc.Name, doc.ParentId, doc.Annotation, doc.FileDocument));
                
            }
            JsonResult json = new JsonResult(Files?.FirstOrDefault());
            return json;
        }
        //Метод выделения папки
        [HttpPost]
        public IActionResult Select(string primarykey)
        {
            Guid id = new Guid(primarykey);
            var file = _context.Docs.Where(d => d.Id == id)?.FirstOrDefault();

            return new JsonResult(file);
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new DocumentViewModel { });
        }

    }
}
