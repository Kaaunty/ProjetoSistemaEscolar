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
        DataTable Listar();

        void Salvar(tipo pessoa);

        void Editar(tipo pessoa);
    }
}