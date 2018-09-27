using System;
using SemesterManagement.Models.Enums;

namespace SemesterManagement.Models
{
    public class Entity
    {
        public long EntityID { get; set; }
        public EntityType Type { get; set; }
    }
}
