using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface IClinicaRepository
    {

        List<Clinicas> Listar();

        Clinicas GetById(int id);

        void Cadastrar(Clinicas clinica);

        void Atualizar(int id, Clinicas clinica);

        void Deletar(int id);
    }
}
