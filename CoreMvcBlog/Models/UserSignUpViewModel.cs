using System.ComponentModel.DataAnnotations;

namespace CoreMvcBlog.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Ad Soyad Giriniz")]
        public string NameSurname { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre Giriniz")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreler Eşleşmemektedir.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Mail Adresi Giriniz")]
        public string Email { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }
    }
}
