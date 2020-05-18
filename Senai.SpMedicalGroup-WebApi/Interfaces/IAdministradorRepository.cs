using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface IAdministradorRepository
    {

        List<Administrador> Listar();

        Administrador GetById(int id);

        void Cadastrar(Administrador adm);

        void Atualizar(int id, Administrador adm);

        void Deletar(int id);
    }
}
