using System.Collections.Generic;

namespace ProjetoSistemaEe.Model
{
    public interface IFunctionModel<tipo>
    {
        List<tipo> GetEntities();

        void Register(tipo pessoa);

        void Edit(tipo pessoa);

        void Delete(tipo pessoa);
    }
}