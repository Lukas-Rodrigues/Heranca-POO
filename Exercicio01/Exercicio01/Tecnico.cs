using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public  class Tecnico : Assistente
    {
        public string turno { get; set; }

        public override double GanhoAnual()
        {
            if (turno.ToUpper() == "NOITE")
            {
                return (_salario * 12) + 100;
            }
            else
            {
                return (_salario * 12);
            }

        }

        public void ExibeDados(List<Tecnico> Lista_Tecnico)
        {

            foreach (Tecnico item in Lista_Tecnico)
            {
                Console.WriteLine("Nome do usuario: " + item._Nome);
                Console.WriteLine("Nome do usuario: " + item.Salario);
                Console.WriteLine("Nome do usuario: " + item.turno);
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            }


        }
    }
}
