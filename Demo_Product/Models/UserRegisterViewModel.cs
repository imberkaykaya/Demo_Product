﻿using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen İsim Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyisim Giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresi Giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
        [Compare("Password", ErrorMessage ="Lütfen şifrelerin eşleştiğinden emin olun")]
        public string ConfirimPassword { get; set; }
    }
}
