using Senai.SpMedicalGroup.WebApi.Domains;
using Senai.SpMedicalGroup.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface IUsuarioRepository
    {

        List<Usuarios> Listar();

        Usuarios GetById(int id);

        void Cadastrar(Usuarios user);

        void Atualizar(int id, Usuarios user);

        void Deletar(int id);

        Usuarios Login(LoginViewModel user);
    }
}
