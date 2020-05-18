using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface INivelAcessoRepository
    {
        List<NiveisAcesso> Listar();

        NiveisAcesso GetById(int id);

        void Cadastrar(NiveisAcesso nivel);

        void Atualizar(int id, NiveisAcesso nivel);

        void Deletar(int id);
    }
}
