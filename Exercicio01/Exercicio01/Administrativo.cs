using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Administrativo: Assistente
    {

        public string turno { get; set; }
        
        
        
        
        public void ExibeDados(List<Administrativo> Lista_Administrativos)
        {

            foreach (Administrativo item in Lista_Administrativos)
            {
                Console.WriteLine("Nome do usuario: " + item._Nome);
                Console.WriteLine("Nome do usuario: " + item.Salario);
                Console.WriteLine("Nome do usuario: " + item.turno);
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            }


        }

        public override double GanhoAnual()
        {
            if(turno.ToUpper() == "NOITE")
            {
                return (_salario * 12) + 100;
            }
            else
            {
                return (_salario * 12);
            }
            
        }

    }
}
