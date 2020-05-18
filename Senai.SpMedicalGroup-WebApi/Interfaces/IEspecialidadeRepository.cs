using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface IEspecialidadeRepository
    {
        List<Especialidades> Listar();

        Especialidades GetById(int id);

        void Cadastrar(Especialidades especialidade);

        void Atualizar(int id, Especialidades especialidade);

        void Deletar(int id);
    }
}
