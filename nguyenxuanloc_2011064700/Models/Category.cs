using System.ComponentModel.DataAnnotations;
using System;

namespace nguyenxuanloc_2011064700.Models
{

    public class Category
    {
        public Byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
    }
}