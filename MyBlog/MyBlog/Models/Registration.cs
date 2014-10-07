using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.Models
{
    public class Registration
    {
        [Required]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password), Display(Name="Password Confirmation"), Compare("Password")]
        public string PasswordConfirmation { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, Display(Name="Avatar")]
        public string Image { get; set; }
    }
}