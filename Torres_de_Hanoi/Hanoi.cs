using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public int m=0;
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (a.top_valor() == 0 ||  b.top_valor() == 0)
            {
                
                if(a.top_valor() == 0 && b.top_valor() != 0)
                {
                    a.push(b.pop());
                     this.m++;
                    
                }
                else if(b.top_valor() == 0&& a.top_valor()!=0)
                {
                    b.push(a.pop());
                     this.m++;
                    
                }

            return;
            }





            if (a.top_valor() != 0 && b.top_valor() != 0)
            {
                if ( a.top_valor() < b.top_valor() )
                {
                b.push(a.pop());
                this.m++;
                
                
                }else if ( a.top_valor() > b.top_valor() ) 
                { 
                a.push(b.pop());
                this.m++; 
                
                }
           
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            
             this.m=0;
            if (n % 2 != 0)
            {
                while (fin.tamaño() < n)
                {
                    
                    mover_disco(ini, fin);
                    print(ini,aux,fin);
                    if (fin.tamaño() == n)
                    {
                        return m;
                    }
                    mover_disco(ini, aux);
                    print(ini,aux,fin);
                    if (fin.tamaño() == n)
                    {
                        return m;
                    }
                    
                    mover_disco(aux, fin);
                    print(ini,aux,fin);
                }
            }
            else
            {
                while (fin.tamaño() < n)
                {
                    
                    mover_disco(ini, aux);
                    print(ini,aux,fin);
                    if (fin.tamaño() == n)
                    {
                        return m;
                    }
                    mover_disco(ini, fin);
                    print(ini,aux,fin);
                    if (fin.tamaño() == n)
                    {
                        return m;
                    }
                    mover_disco(aux, fin);
                    print(ini,aux,fin);
                }
            }
            return m;
        }
        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            
            if (n == 1)
            {
                mover_disco(ini,fin);
                print(ini,aux,fin);
            }
            else
            {
                recursivo(n-1,ini,aux,fin);
                mover_disco(ini,fin);
                print(ini,aux,fin);
                recursivo(n-1,aux,fin,ini);
            }
            return m;
        }





        public void print(Pila a,Pila b, Pila c)
        {
            Console.WriteLine("INICIAL: "+a+  " AUXILIAR:" +b+ " FINAL:" +c);
        }
        

    }
}



