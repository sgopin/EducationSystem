using System;
namespace SemesterManagement.Models
{
    public class Host
    {
        public long HostID { get; set; }
        public string URL { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsDefault { get; set; }
        public Semester Semester { get; set; }
    }
}
