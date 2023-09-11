using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistemaEe.Model
{
    internal interface IPessoaModel<tipo>
    {
        List<tipo> Listar();

        void Salvar(tipo pessoa);

        void Editar(tipo pessoa);

        void Excluir(tipo pessoa);
    }
}