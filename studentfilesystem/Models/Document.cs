using System;
using System.Collections.Generic;

namespace studentfilesystem.Models
{
    public partial class Document
    {
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public byte[] Document1 { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int ApplicationId { get; set; }

        public virtual Application Application { get; set; }
    }
}
