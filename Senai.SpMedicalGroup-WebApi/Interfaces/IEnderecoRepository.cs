using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface IEnderecoRepository
    {

        List<Enderecos> Listar();

        Enderecos GetById(int id);

        void Cadastrar(Enderecos endereco);

        void Atualizar(int id, Enderecos enderecos);

        void Deletar(int id);
    }
}
