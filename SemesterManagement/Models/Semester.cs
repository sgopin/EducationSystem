using System;
namespace SemesterManagement.Models
{
    public class Semester
    {
        public long SemesterID { get; set; }
        public string Name { get; set; }
        public string Desription { get; set; }
        public Entity Entity { get; set; }
        public Template Template { get; set; }
    }
}
