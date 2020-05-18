using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.SpMedicalGroup.WebApi.Domains
{
    public partial class Especialidades
    {
        public Especialidades()
        {
            Medicos = new HashSet<Medicos>();
        }

        public int IdEspecialidade { get; set; }

        [Required(ErrorMessage = "O Titulo é obrigatório!")]
        [DataType(DataType.Text)]
        public string Titulo { get; set; }

        public ICollection<Medicos> Medicos { get; set; }
    }
}
