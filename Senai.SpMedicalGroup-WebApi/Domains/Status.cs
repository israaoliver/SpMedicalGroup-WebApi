using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.SpMedicalGroup.WebApi.Domains
{
    public partial class Status
    {
        public Status()
        {
            Consultas = new HashSet<Consultas>();
        }

        public int IdStatus { get; set; }

        [Required(ErrorMessage = "O Titulo é obrigatório!")]
        [DataType(DataType.Text)]
        public string Titulo { get; set; }

        public ICollection<Consultas> Consultas { get; set; }
    }
}
