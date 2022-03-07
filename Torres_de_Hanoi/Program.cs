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
            int solucion;
            string p;
            Hanoi h=new Hanoi();

            Console.WriteLine("cuantos discos quieres?");
            string a = Console.ReadLine();
            int n = Int16.Parse(a);

            Pila ini=new Pila(n);
            Pila fin=new Pila();
            Pila aux = new Pila();

             Console.WriteLine("quieres calcularlo en interativo o recursivo?(I o R)");
            string letra = Console.ReadLine();
            if(letra == "I"||letra == "i")
            {
                 solucion =h.iterativo(n, ini, fin, aux);
            }else if(letra == "R"||letra == "r" )
            {
                 solucion =h.recursivo(n,ini,fin,aux);
            }
            else
            {
                Console.WriteLine("lo siento no te he entendido");
                 p = Console.ReadLine();
                return ;
            }

           
            Console.WriteLine();
            Console.WriteLine(solucion);
             p = Console.ReadLine();
        }
    }
}
