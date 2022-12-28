using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Funcionario
    {
        public string _Nome { get; set; }
        protected double _salario;
  

        public double Salario
        {
            get { return _salario; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"O valor {value} não pode ser adicionado ao salario.");
                }
                _salario = value;   
            }
        }




        public void AddAumento(double valor)
        {
            _salario+=valor;    
        }

        public virtual void ExibeDados(List<Funcionario> Lista_funcionario)
        {
  
            foreach (Funcionario  item in Lista_funcionario)
            {
                Console.WriteLine("Nome do usuario: " + item._Nome);
                Console.WriteLine("Nome salario: " + item._salario);
                Console.WriteLine($"salario anual: {item.GanhoAnual()} ");
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            }
           

        }
        public virtual double GanhoAnual()
        {
            return _salario*12;
        }


    }
}
