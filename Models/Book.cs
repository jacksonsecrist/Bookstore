﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Book
    {
        //properties
        [Key]
        [Required]
        public int BookID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        [RegularExpression("^[0-9]{3}-[0-9]{10}$")]
        public string ISBN { get; set; }

        [Required]
        public string Classification { get; set; }
        
        [Required]
        public string Category { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int NumPages { get; set; }
    }
}
