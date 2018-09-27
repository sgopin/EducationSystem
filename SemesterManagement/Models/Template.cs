using System;
namespace SemesterManagement.Models
{
    public class Template
    {
        public long TemplateID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TemplateImage { get; set; }
    }
}
