using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface IPacienteRepository
    {

        List<Pacientes> Listar();

        Pacientes GetById(int id);

        void Cadastrar(Pacientes paciente);

        void Atualizar(int id, Pacientes paciente);

        void Deletar(int id);
    }
}
