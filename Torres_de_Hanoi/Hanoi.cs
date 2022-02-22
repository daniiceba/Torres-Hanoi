using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (a.top_valor() < b.top_valor())
            {
                b.push(a.pop());
                
            }else if(a.top_valor() > b.top_valor()) { a.push(b.pop()); }
           
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            
            int m=0;
            if (n % 2 != 0)
            {
                while (fin.tamaño() < 3)
                {
                    m++;
                    mover_disco(ini, fin);
                    m++;
                    mover_disco(ini, aux);
                    m++;
                    mover_disco(aux, fin);
                }
            }
            if(n % 2 == 0)
            {
                while (fin.tamaño() < 3)
                {
                    m++;
                    mover_disco(ini, aux);
                    m++;
                    mover_disco(ini, fin);
                    m++;
                    mover_disco(aux, fin);
                }
            }
            return m;
        }

    }
}



