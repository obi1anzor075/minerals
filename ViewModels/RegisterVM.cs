using System.ComponentModel.DataAnnotations;

namespace minerals.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Это обязательное поле")]
        [Display(Name = "Имя")]
        public string? Name { get; set; }

        [Display(Name = "Почта")]
        [Required(ErrorMessage = "Это обязательное поле")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Это обязательное поле")]
        public string? Password { get; set; }
        [Display(Name = "Поддтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [Required(ErrorMessage = "Это обязательное поле")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
    }
}
