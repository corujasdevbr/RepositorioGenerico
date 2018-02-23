using System.Collections.Generic;

namespace senai.ifood.domain.Contracts
{
    public interface IBaseRepository<T> where T : class
    {
         IEnumerable<T> Listar();
         
         int Atualizar(T dados);

         int Inserir(T dados);

         int Deletar(T dados);

         T BuscarPorId(int id);
    }
}