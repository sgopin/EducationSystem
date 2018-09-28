using System;
using System.ComponentModel.DataAnnotations;

namespace SemesterManagement.Models
{
    public class Template
    {
        public long TemplateId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TemplateImage { get; set; }
    }
}
