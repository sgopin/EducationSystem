using System;
using System.ComponentModel.DataAnnotations;

namespace SemesterManagement.Models
{
    public class Host
    {
        public long HostId { get; set; }
        [MaxLength(100)]
        public string URL { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsDefault { get; set; }

        public long SemesterId { get; set; }
        public Semester Semester { get; set; }
    }
}
