using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace StudentMGMT.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<StudentModel> Students { get; set; }
    }
}