using BitBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("032.437.855.61");
            carlos.Nome = "Antonio Carlos";           
            carlos.Salario = 3300;
            Console.WriteLine("Número do Funcionário: " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine("Salário do funcionário: " + carlos.Nome + " " + carlos.Salario);
            Console.WriteLine("Bonificação do funcionário: " + carlos.GetBonificacao());

            Console.WriteLine("----------------------------------------");

            Diretor barbara = new Diretor("132.847.588.63");
            barbara.Nome = "Barbara Sousa";          
            barbara.Salario = 4000;
            Console.WriteLine("Número do Funcionário: " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine("Salário do diretor: " + barbara.Nome + " " + barbara.Salario);
            Console.WriteLine("Bonficação do funcionário: " + barbara.GetBonificacao());

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(barbara);


            //Console.WriteLine("Salário do funcionário: " + carlos.Nome + " " + carlos.Salario);
            //Console.WriteLine("Bonificação do funcionário: " + carlos.GetBonificacao());
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Salário do diretor: " + barbara.Nome + " " + barbara.Salario);
            //Console.WriteLine("Bonficação do funcionário: " + barbara.GetBonificacao());
            //Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadKey();
        }
    }
}
