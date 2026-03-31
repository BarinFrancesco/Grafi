using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo
{
    public class Grafo<T> 
    {
        public int[,] matrice;
        public T[] Nodi;
        private int index;


        public Grafo(int max) 
        {
            matrice = new int[max, max];
            Nodi = new T[max];
            index = 0;
        }


        public void Add(T value)
        {
            Nodi[index] = value;
            matrice[index, index] = 0;
            index++;
        }

        public void AddMonoDirectionArch(T FirtNode, T SecondNode) 
        {
            int y = Array.IndexOf(Nodi, FirtNode);
            int x = Array.IndexOf(Nodi, SecondNode);

            if( y == -1 || x == -1  ) 
            {
                throw new ArgumentNullException("Uno dei due valori non è valorizzato");
            }

            matrice[y, x] = 1;
        }
        /*
        public void AddDoubleDirectionsArches(T FirtNode, T SecondNode) 
        {
            int y = Array.IndexOf(Nodi, FirtNode);
            int x = Array.IndexOf(Nodi, SecondNode);

            if (y == -1 || x == -1)
            {
                throw new ArgumentNullException("Uno dei due valori non è valorizzato");
            }

            matrice[y, x] = 1;
            matrice[x, y] = 1;
        }*/
    }
}
