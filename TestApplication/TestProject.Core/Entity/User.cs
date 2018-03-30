﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestProject.Core.Entity
{
    public class User
    {
        public int EmpNo { get; set; }
        [Required(ErrorMessage = "EmpName is Must")]
        [RegularExpression("^[A-Z]+$", ErrorMessage = "Must be Upper Case")]
        [MaxLength(30, ErrorMessage = "Must be Maximum 30 Characters")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Salary is Must")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Must be Nemeric")]
        public decimal Salary { get; set; }
        [Required(ErrorMessage = "DeptName is Must")]
        [RegularExpression("^[A-Z]+$", ErrorMessage = "Must Start with UpperCase Character")]
        [MaxLength(30, ErrorMessage = "Must be Maximum 20 Characters")]
        public string DeptName { get; set; }
        [Required(ErrorMessage = "Designation is Must")]
        [MaxLength(30, ErrorMessage = "Must be Maximum 20 Characters")]
        public string Designation { get; set; }
    }



}
