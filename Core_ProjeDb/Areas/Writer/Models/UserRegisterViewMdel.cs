using System.ComponentModel.DataAnnotations;

namespace Core_ProjeDb.Areas.Writer.Models
{
    public class UserRegisterViewMdel
    {
        [Required(ErrorMessage = "Lütfen Adınızı  Giriniz")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string SurName { get; set; }


        [Required(ErrorMessage = "Lütfen Resim Url Değeri Giriniz")]
        public string ImageUrl { get; set; }


        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Lütfen Şifreyi Giriniz")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil")]
        public string ConfirmPssword { get; set; }


        [Required(ErrorMessage = "Lütfen Mail Giriniz")]
        public string Mail { get; set; }
    }
}
