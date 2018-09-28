using System;
using Microsoft.EntityFrameworkCore;
using SemesterManagement.Models.Enums;

namespace SemesterManagement.Models
{
    public class SMDBContext : DbContext
    {
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Institute> Institutes { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Host> Hosts { get; set; }

        public SMDBContext(DbContextOptions<SMDBContext> options) : base (options)
        {
            Database.EnsureCreated();
        }
    }
}
