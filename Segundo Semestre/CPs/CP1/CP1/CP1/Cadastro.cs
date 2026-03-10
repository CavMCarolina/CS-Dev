using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1
{
    public class Cadastro<T>
    {
        private Dictionary<int, T> cadastro = new Dictionary<int, T>();

        public void Adicionar(int id, T item) => cadastro[id] = item;
        public IEnumerable<T> ListarTodos() => cadastro.Values;
        public T BuscarPorId(int id) => cadastro.TryGetValue(id, out T item) ? item : default;
        public bool Remover(int id) => cadastro.Remove(id);
    }
}