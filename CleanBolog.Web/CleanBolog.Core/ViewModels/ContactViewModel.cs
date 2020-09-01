using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBolog.Core.ViewModels
{
    public class ContactViewModel
    {
        public int ContactFormID { get; set; }
        [Required(ErrorMessage ="Lütfen isminizi giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Lütfen Email adresinizi giriniz.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage ="Lütfen mesajınızı giriniz.")]
        [MaxLength(500,ErrorMessage ="500 karakteri geçemez.")]
        public string Message { get; set; }
    }
}
