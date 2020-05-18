using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface IMedicoRepository
    {

        List<Medicos> Listar();

        Medicos GetById(int id);

        void Cadastrar(Medicos med);

        void Atualizar(int id, Medicos med);

        void Deletar(int id);
    }
}
