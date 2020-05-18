using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface IStatusRepository
    {

        List<Status> Listar();

        Status GetById(int id);

        void Cadastrar(Status status);

        void Atualizar(int id, Status status);

        void Deletar(int id);
    }
}
