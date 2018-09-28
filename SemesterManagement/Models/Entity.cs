using System;
using System.ComponentModel.DataAnnotations.Schema;
using SemesterManagement.Models.Enums;

namespace SemesterManagement.Models
{
    public class Entity
    {
        public long EntityId { get; set; }
        [Column(TypeName = "int")]
        public EntityType Type { get; set; }
    }
}
