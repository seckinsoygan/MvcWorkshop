﻿using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(100)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        public ICollection<Heading> Headings { get; set; }
    }
}
