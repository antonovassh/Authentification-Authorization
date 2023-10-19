﻿using System.ComponentModel.DataAnnotations;

namespace TaskAuthenticationAuthorization.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Email hasn't been set")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password hasn't been set")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords doesn't match")]
        public string ConfirmPassword { get; set; }
    }
}
