﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Form113.Models
{
    public class NewsLettersViewModel
    {
       public string Message { get; set; }
        [Required]
        [EmailAddress]
       public string Email { get; set; }
       public int Id { get; set; }
    }
}