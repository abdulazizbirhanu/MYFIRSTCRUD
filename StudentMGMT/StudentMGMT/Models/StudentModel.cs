using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentMGMT.Models
{
    public class StudentModel
    {
        public int Id{ get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public char Sex { get; set; }
        public int Age { get; set; }
        public string School { get; set; }
        public string Batch { get; set; }
        
    }
}