using System.Collections.Generic;

namespace ProjetoSistemaEe.Model
{
    public interface IFunctionModel<tipo>
    {
        List<tipo> GetEntities();

        void Register(tipo entitiy);

        void Edit(tipo entitiy);

        void Delete(tipo entitiy);
    }
}