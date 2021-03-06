﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestCases.Models
{
    public class CaseStep
    {
        [Key]
        public int Id { get; set; }
        public TestCase TestCase { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int Step { get; set; }
    }
}
