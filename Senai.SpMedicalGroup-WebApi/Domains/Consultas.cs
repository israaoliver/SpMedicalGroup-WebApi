using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.SpMedicalGroup.WebApi.Domains
{
    public partial class Consultas
    {
        public int IdConsulta { get; set; }

        public int? IdStatus { get; set; }

        [Required(ErrorMessage = "É necessario informar o médico!")]
        public int IdMedico { get; set; }

        [Required(ErrorMessage = "É necessario informar o paciente!")]
        public int IdPaciente { get; set; }

        [Required(ErrorMessage = "A data é obrigatório!")]
        [DataType(DataType.Date)]
        public DateTime DataConsulta { get; set; }

        [Required(ErrorMessage = "O horario é obrigatório!")]
        [DataType(DataType.Time)]
        public TimeSpan HoraConsulta { get; set; }
        public string Descricao { get; set; }

        public Medicos IdMedicoNavigation { get; set; }
        public Pacientes IdPacienteNavigation { get; set; }
        public Status IdStatusNavigation { get; set; }
    }
}
