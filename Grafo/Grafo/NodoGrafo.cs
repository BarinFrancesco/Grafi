using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo
{
    public class NodoGrafo<T>
    {
        public T Data;

        public NodoGrafo(T Data) {  this.Data = Data; }
    }
}
