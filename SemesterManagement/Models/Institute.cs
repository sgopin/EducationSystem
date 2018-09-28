using System;
using System.ComponentModel.DataAnnotations;

namespace SemesterManagement.Models
{
    public class Institute
    {
        public long InstituteId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public long EntityId { get; set; }
        public Entity Entity { get; set; }
    }
}
