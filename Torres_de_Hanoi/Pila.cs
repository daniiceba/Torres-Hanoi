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
            for (int i = n; i < 0; i--)
            {
                Disco pp = new Disco(n);
                Elementos.Add(pp);
            }
        }
        public Pila() {  }

        public int tamaño()
        {
            try
            {
                return Elementos.Count();
            }catch(Exception) { return 0; }
            
        }

        public int top_valor()
            
        {
            try
            {
                return Elementos[Elementos.Count() - 1].valor;
            }
            catch (Exception) { return 0; }
            
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
        }

        public Disco pop()
        {
            if (this.isEmpty()) { return null; }
            
            else
            {
                Disco aux = Elementos[Elementos.Count - 1];
                Elementos.RemoveAt(Elementos.Count - 1);   
                return aux ;
            }
        }                

        public bool isEmpty()
        {
            if(Elementos.Count == 0) { return true; } else { return false; }
        }

    }
}
