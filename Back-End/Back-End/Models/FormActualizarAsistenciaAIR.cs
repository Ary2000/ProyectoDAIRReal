﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Back_End.Models
{
    public class FormActualizarAsistenciaAIR
    {
        public string Id { get; set; }
        public string NombrePadron { get; set; }
        public HttpPostedFileBase ArchivoPadron { get; set; }
    }
}