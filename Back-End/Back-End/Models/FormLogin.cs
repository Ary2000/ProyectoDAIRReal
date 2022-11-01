using System.ComponentModel.DataAnnotations;

namespace Back_End.Models
{
    public class FormLogin
    {
        [Required]
        public string Usuario { get; set; }
        
        [Required]
        public string Contrasenna { get; set; }
        
    }
}