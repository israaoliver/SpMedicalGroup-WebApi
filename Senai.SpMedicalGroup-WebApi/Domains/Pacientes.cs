using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.SpMedicalGroup.WebApi.Domains
{
    public partial class Pacientes
    {
        public Pacientes()
        {
            Consultas = new HashSet<Consultas>();
        }

        public int IdPaciente { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdEndereco { get; set; }

        [Required(ErrorMessage = "O nome do Paciente é obrigatório!")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A data de nascimento  é obrigatória!")]
        [DataType(DataType.Date)]
        public DateTime DataNacimento { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório!")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O RG é obrigatório!")]
        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Apenas Números")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório!")]
        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Apenas Números")]
        public string Cpf { get; set; }

        public Enderecos IdEnderecoNavigation { get; set; }
        public Usuarios IdUsuarioNavigation { get; set; }
        public ICollection<Consultas> Consultas { get; set; }
    }
}
