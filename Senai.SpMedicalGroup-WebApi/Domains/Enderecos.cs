using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.SpMedicalGroup.WebApi.Domains
{
    public partial class Enderecos
    {
        public Enderecos()
        {
            Clinicas = new HashSet<Clinicas>();
            Pacientes = new HashSet<Pacientes>();
        }

        public int IdEndereco { get; set; }

        [Required(ErrorMessage = "O Estado é obrigatório!")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O Cidade é obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório!")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O Rua é obrigatório!")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "O Numero é obrigatório!")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O Cep é obrigatório!")]
        [DataType(DataType.PostalCode)]
        public string Cep { get; set; }

        public ICollection<Clinicas> Clinicas { get; set; }
        public ICollection<Pacientes> Pacientes { get; set; }
    }
}
