using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Register.Models
{
    public class RegisterViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        [MinLength(5)]
        public string KullaniciAdi { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        public string Telefon { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
        [DataType(DataType.Password)]
        [Compare("Sifre",ErrorMessage ="Şifreler Uyuşmuyor.")]
        public string SifreOnay { get; set; }
    }
}