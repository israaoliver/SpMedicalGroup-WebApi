using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.SpMedicalGroup.WebApi.Domains
{
    public partial class Administrador
    {
        public int IdAdm { get; set; }

        [Required(ErrorMessage = "O nome de adm é obrigatório!")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage ="Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }

        public Usuarios IdUsuarioNavigation { get; set; }
    }
}
