using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Interfaces
{
    public interface IRepository<T>
    {
        void Inserir(T obj);
        List<T> Consultar();
    }
}
