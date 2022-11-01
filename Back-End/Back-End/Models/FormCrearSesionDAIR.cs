
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Back_End.Models
{
    public class FormCrearSesionDAIR
    {
        public string Nombre { get; set; }
        [Required]
        public int Periodo { get; set; }
        public string Fecha { get; set; }
        public string TiempoInicial { get; set; }
        public string TiempoFinal { get; set; }
        
    }
}