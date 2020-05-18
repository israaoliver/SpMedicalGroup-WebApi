using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.SpMedicalGroup.WebApi.Domains
{
    public partial class Clinicas
    {
        public Clinicas()
        {
            Medicos = new HashSet<Medicos>();
        }

        public int IdClinica { get; set; }

        [Required(ErrorMessage = "É necessario informar o endereço!")]
        public int IdEndereco { get; set; }

        [Required(ErrorMessage = "A Razão Social é obrigatória!")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos na Razão Social")]
        public string RazaoSocial { get; set; }

        [RegularExpression(@"^[0-9]{14}$", ErrorMessage = "Apenas Números")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "O horario é obrigatório!")]
        [DataType(DataType.Time)]
        public TimeSpan HrAbertura { get; set; }

        [Required(ErrorMessage = "O horario é obrigatório!")]
        [DataType(DataType.Time)]
        public TimeSpan HrFechamento { get; set; }

        public Enderecos IdEnderecoNavigation { get; set; }
        public ICollection<Medicos> Medicos { get; set; }
    }
}
