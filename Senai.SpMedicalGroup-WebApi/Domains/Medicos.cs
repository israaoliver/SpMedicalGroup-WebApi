using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.SpMedicalGroup.WebApi.Domains
{
    public partial class Medicos
    {
        public Medicos()
        {
            Consultas = new HashSet<Consultas>();
        }

        public int IdMedico { get; set; }
        public int? IdEspecialidade { get; set; }
        public int? IdClinica { get; set; }
        public int? IdUsuario { get; set; }

        [Required(ErrorMessage = "O nome do Médico é obrigatório!")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Crm é obrigatório!")]
        [RegularExpression(@"^[0-9]{5}[A-Z]{2}$", ErrorMessage = "O Crm deve ter 5 digitos, depois o Uf ")]
        public string Crm { get; set; }

        public Clinicas IdClinicaNavigation { get; set; }
        public Especialidades IdEspecialidadeNavigation { get; set; }
        public Usuarios IdUsuarioNavigation { get; set; }
        public ICollection<Consultas> Consultas { get; set; }
    }
}
