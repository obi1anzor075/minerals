using System.ComponentModel.DataAnnotations;

namespace minerals.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Почта")]
        [Required(ErrorMessage = "Это обязательное поле")]
        public string? UserName { get; set; }

        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Это обязательное поле")]
        public string? Password { get; set; }

        public bool RememberMe { get; set; }

    }
}
