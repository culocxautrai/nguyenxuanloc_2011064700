using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nguyenxuanloc_2011064700.Models
{
    public class course
    {
        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        public string LecturerId { get; set; }
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        public byte CategoryId { get; set; }
        
    }
    public class category
    {
        public byte Id { get; set; }
        public string Name { get; set; }
    }
}