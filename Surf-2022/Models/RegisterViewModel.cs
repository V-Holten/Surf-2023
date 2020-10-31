using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Surf_2022.Models
{
    public class RegisterViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [DataType(DataType.Text)]
        [Display(Name = "Brugernavn")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress, MaxLength(500)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Kodeord")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Kodeord skal matche")]
        [Display(Name = "Bekræft kodeord")]
        public string ConfirmPassword { get; set; }
    }
}
