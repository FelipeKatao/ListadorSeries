using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casdastro_de_Series.Interfaces
{
    interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornoId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}
