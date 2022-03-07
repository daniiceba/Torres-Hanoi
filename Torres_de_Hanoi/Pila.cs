using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        
       
       
        public List<Disco> Elementos { get; set; }
        

        /* TODO: Implementar métodos */
        public Pila(int n)
        {
            Elementos = new List<Disco>();
            for (int i = n; i > 0; i--)
            {
                Disco p = new Disco(i);
                Elementos.Add(p);
            }
        }

        public Pila() { 
         Elementos = new List<Disco>();
        }

        public int tamaño()
        {
            if(this.isEmpty())
            {
                 return 0;
               
            }
            else {  return Elementos.Count;}
            
        }

        public int top_valor() 
        {
            if (this.isEmpty())
            {
                return 0;
                 
            }
            else {
                
                return this.Elementos.Last().valor;
                 
            }
            
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
        }

        public Disco pop()
        {
           if(this.isEmpty())
            {
                return null;
            }
            else
            {
                Disco aux = this.Elementos.Last();  //Elementos[this.Elementos.Count - 1];
                Elementos.RemoveAt(this.Elementos.Count - 1);   
                return aux;
            }
                
           
                
            
        }                

        public bool isEmpty()
        {
            if(Elementos==null||Elementos.Count==0) { return true; } else { return false; }
        }
        public override string ToString()
        {
           String sol= "";
            for(int i = 0; i < Elementos.Count; i++)
            {
                sol=sol+Elementos[i].ToString()+ ' ';
            }
            return sol;
        }

    }
}
