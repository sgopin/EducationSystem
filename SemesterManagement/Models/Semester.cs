using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SemesterManagement.Models
{
    public class Semester
    {
        public long SemesterId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Host> Hosts { get; set; }

        public long EntityId { get; set; }
        public Entity Entity { get; set; }

        public long InstituteId { get; set; }
        public Institute Institute { get; set; }

        public long TemplateId { get; set; }
        public Template Template { get; set; }
    }
}
