using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi h=new Hanoi();
            Pila ini=new Pila();
            Pila fin=new Pila();
            Pila aux = new Pila();
            Console.WriteLine("cuantos discos quieres?");
            string a = Console.ReadLine();
            int n = Int16.Parse(a);
            int solucion = h.iterativo(n, ini, fin, aux);
            Console.WriteLine(solucion);
        }
    }
}
