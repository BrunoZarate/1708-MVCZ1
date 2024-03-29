﻿using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class Product
    {
        [Key]
        public int productID { get; set; }

        [Required]
        [Display(Description ="Product Name")]
        public string Name { get; set; }

        public string Description { get; set; }
       
    }
}