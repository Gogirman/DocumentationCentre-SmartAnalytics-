using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationCenter.Models
{
    public abstract class AbstractFile
    {

        public Guid Id { get; set; }
        public string Annotation { get; set; }
        public string Name { get; set; }
        public string BaseIcon { get; set; }
        public Guid? ParentId{ get; set; }
        public bool IsSelected { get; set; }
        public string Format{ get; set; }
        public byte[] FileDocument { get; set; }
    }

    public class Folder : AbstractFile
    {
        public Folder(Guid id, string name, Guid? parentId, string annotation)
        {
            Id = id;
            Annotation = annotation;
            BaseIcon = "https://image.flaticon.com/icons/svg/148/148953.svg";
            Name = name;
            ParentId = parentId;
            IsSelected = false;
        }
    }

    public class DocumentWord : AbstractFile
    {
        public DocumentWord(Guid id, string name, Guid? parentId, string annotation, byte[] fileDocument)
        {
            Id = id;
            Annotation = annotation;
            BaseIcon = "https://image.flaticon.com/icons/svg/888/888883.svg";
            Name = name;
            ParentId = parentId;
            IsSelected = false;
            Format = name.Substring(name.Length - 4);
            FileDocument = fileDocument;

        }
    }

    public class DocumentExcel : AbstractFile
    {
        public DocumentExcel(Guid id, string name, Guid? parentId, string annotation, byte[] fileDocument)
        {
            Id = id;
            Annotation = annotation;
            BaseIcon = "https://image.flaticon.com/icons/svg/732/732220.svg";
            Name = name;
            ParentId = parentId;
            IsSelected = false;
            Format = name.Substring(name.Length - 4);
            FileDocument = fileDocument;
        }
    }
}
