using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface IConsultaRepository
    {

        List<Consultas> Listar();

        Consultas GetById(int id);

        void Cadastrar(Consultas consulta);

        void Atualizar(int id, Consultas consulta);

        void Deletar(int id);

        IEnumerable<Consultas> ListByMed(int idMedico);

        IEnumerable<Consultas> ListByPaci(int idPaciente);
    }
}
