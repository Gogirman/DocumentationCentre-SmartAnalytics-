using System;
using System.Collections.Generic;
using System.Text;

namespace DataProvider.Entities
{
    public class Docs 
    {
        public Guid Id
        {
            get; set;
        }

        public string Annotation
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public Guid? ParentId
        {
            get; set;
        }

        public byte[] FileDocument
        {
            get; set;
        }


    }
}
