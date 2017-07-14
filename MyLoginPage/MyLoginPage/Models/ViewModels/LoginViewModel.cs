using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyLoginPage.Models.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress]
        public string Account { get; set; }
        [StringLength(20, MinimumLength = 4)]
        public string Password { get; set; }
        public string Message { get; set; }
    }
}