using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Implemente a classe Funcionario com nome, salario e os métodos
//addAumento(double valor), ganhoAnual() e exibeDados() -imprime os valores do funcionário.

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> Lista_funcionario = new List<Funcionario>();
            Funcionario funcionario = new Funcionario();

            funcionario.Salario = 100;
            funcionario._Nome = "Lucas";
            Lista_funcionario.Add(funcionario);
            funcionario.AddAumento(500);
            funcionario.ExibeDados(Lista_funcionario);
            Console.ReadKey();
           
            
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            List<Tecnico> Lista_Tecnico = new List<Tecnico>();
            Tecnico tecnico = new Tecnico();

            tecnico.Salario = 100;
            tecnico._Nome = "administrativo";
            tecnico.turno = "noite";
            Console.ReadKey();
            
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>");
            List<Administrativo> Lista_Administrativo = new List<Administrativo>();
            Administrativo administrativo = new Administrativo();
            Console.ReadKey();
            tecnico.Salario = 100;
            tecnico._Nome = "tecnico";
            tecnico.turno = "Dia";

        }
    }
}
