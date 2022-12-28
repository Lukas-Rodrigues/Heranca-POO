using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Assistente : Funcionario
    {
        public string matricula { get; private set; }


        public virtual void ExibeDados(List<Assistente> Lista_Assistente)
        {

            foreach (Assistente item in Lista_Assistente)
            {
                Console.WriteLine("Nome do usuario: " + item._Nome);
                Console.WriteLine("Nome do usuario: " + item._salario);
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            }


        }
    }


}

