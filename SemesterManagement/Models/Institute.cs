using System;
namespace SemesterManagement.Models
{
    public class Institute
    {
        public long InstituteID { get; set; }
        public string Name { get; set; }

        public Entity Entity { get; set; }
    }
}
