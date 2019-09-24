using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationCenter.Models
{
    public class FileViewModel
    {
        public string Annotation { get; set; }

        public string Name { get; set; }

        public IFormFile FileDocument { get; set; }
       
        public bool IsSelected { get; set; } 

        public Guid MasterGuid { get; set; }
    }
}
