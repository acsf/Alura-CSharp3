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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("+-------------Bem vindo ao BitBank-------------+");
            Console.WriteLine("");

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(3300, "032.437.855.61");
            carlos.Nome = "Antonio Carlos";
            Console.WriteLine("Número do Funcionário: " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine("Salário do funcionário: " + carlos.Nome + " " + carlos.Salario);
            Console.WriteLine("Bonificação do funcionário: " + carlos.GetBonificacao());
            carlos.AumentarSalario();
            Console.WriteLine("O novo salário do funcionário é: " + carlos.Salario);

            Console.WriteLine("+----------------------------------------+");

            Diretor barbara = new Diretor("132.847.588.63");
            barbara.Nome = "Barbara Sousa";
            Console.WriteLine("Número do Funcionário: " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine("Salário do diretor: " + barbara.Nome + " " + barbara.Salario);
            Console.WriteLine("Bonficação do funcionário: " + barbara.GetBonificacao());
            barbara.AumentarSalario();
            Console.WriteLine("O novo salário da diretora é: " + barbara.Salario);

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(barbara);


            //Console.WriteLine("Salário do funcionário: " + carlos.Nome + " " + carlos.Salario);
            //Console.WriteLine("Bonificação do funcionário: " + carlos.GetBonificacao());
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Salário do diretor: " + barbara.Nome + " " + barbara.Salario);
            //Console.WriteLine("Bonficação do funcionário: " + barbara.GetBonificacao());
            //Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.WriteLine("");
            Console.WriteLine("+----------Imagine Software 2019----------------+");
            Console.ReadKey();
        }
    }
}
