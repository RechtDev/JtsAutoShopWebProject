using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models.DTOs
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Confirm password is Required")]
        [Compare("Password", ErrorMessage ="The password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
