using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<t> Lista();

        T RetornaPorId( int id);

        void Insere( T entidade);

        void Exclui(int id);

        void Atualiza(int id, T entidade);

        int ProximoID();

    }

}