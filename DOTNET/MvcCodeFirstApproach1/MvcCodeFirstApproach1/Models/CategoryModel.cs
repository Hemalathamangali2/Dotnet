﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCodeFirstApproach1.Models
{
    [Table("tblCategory")]
    public class Category
    {
            [Key]
            public int CategoryId { get; set; }
            public string Name { get; set; }
            public List<Product> Products { get; set; }
        }

    }

