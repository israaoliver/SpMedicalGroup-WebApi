using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.SpMedicalGroup.WebApi.Domains
{
    public partial class NiveisAcesso
    {
        public NiveisAcesso()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdNivelAcesso { get; set; }

        [Required(ErrorMessage = "O Titulo é obrigatório!")]
        [DataType(DataType.Text)]
        public string Titulo { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
