using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato();
            gato.nome = "adsasfd";
            gato.raca = "sdfsdfs";
            Console.WriteLine(gato.nome);
            Console.WriteLine(gato.raca);
            gato.Mia();

            Cachorro cachorro = new Cachorro();
            cachorro.nome = "adsasfd";
            cachorro.raca = "sdfsdfs";
            Console.WriteLine(cachorro.nome);
            Console.WriteLine(cachorro.raca);
            cachorro.late();
            Console.ReadKey();
        }
    }
}
