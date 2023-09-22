using System.Collections.Generic;

namespace ProjetoSistemaEe.Model
{
    public interface IFunctionModel<type>
    {
        List<type> GetEntities();

        void Register(type entitiy);

        void Edit(type entitiy);

        void Delete(type entitiy);
    }
}