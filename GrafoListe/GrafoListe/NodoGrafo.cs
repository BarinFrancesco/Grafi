using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoListe
{
    public class NodoGrafo<T>
    {
        public T Data;
        public List<NodoGrafo<T>> ListaAdiacenti;
        public NodoGrafo(T data) 
        {  
            Data = data;
            ListaAdiacenti = new List<NodoGrafo<T>>();
        }
    }
}
