﻿using HPlus.Ecommerce.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HPlus.Ecommerce.Models
{
    public class Login
    {
        [Required]
        [EmailAddress(ErrorMessage ="Username must be valid email addresses")]
        public string Username { get; set; }
        [Required]
        [MinLength(8, ErrorMessage ="Too Short")]
        [CommonPasswords(ErrorMessage ="This password is too common")]
        public string Password { get; set; }

    }
}