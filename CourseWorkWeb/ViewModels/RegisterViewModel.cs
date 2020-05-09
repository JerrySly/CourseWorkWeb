using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkWeb.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-?!]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [RegularExpression(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^_])(?!.*\s).{6,15})", ErrorMessage = "Некорректный пароль. Длина от 6 до 15. Пароль должен содержать цифры, буквы разного регистра, символ из @#$%^_")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
    }
}
