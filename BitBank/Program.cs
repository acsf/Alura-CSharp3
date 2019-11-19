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

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Antonio Carlos";
            carlos.CPF = "032.437.855.61";
            carlos.Salario = 3300;

            Diretor barbara = new Diretor();
            barbara.Nome = "Barbara Sousa";
            barbara.CPF = "132.847.588.63";
            barbara.Salario = 3000;

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(barbara);

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadKey();
        }
    }
}
