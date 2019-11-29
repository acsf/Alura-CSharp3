﻿using BitBank.Funcionarios;
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
            Console.WriteLine("+--------------Bem vindo ao BitBank-------------+");
            Console.WriteLine("");
     
            CalcularBonificacao();

            Console.WriteLine("");
            Console.WriteLine("+----------Imagine Software 2019----------------+");
            Console.ReadKey();
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario zack = new Designer("03284434769")
            {
                Nome = "Zack Lavine"
            };

            Funcionario barbara = new Diretor("13253768899")
            {
                Nome = "Barbara Sousa"
            };

            Funcionario lauri = new Auxiliar("23264578955")
            {
                Nome = "Lauri Markannen"
            };

            Funcionario camila = new GerenteDeConta("47854678944")
            {
                Nome = "Camila Andrade"
            };

            Funcionario carlos = new Desenvolvedor("03243785561")
            {
                Nome = "Antonio Carlos"
            };

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(zack);
            gerenciador.Registrar(barbara);
            gerenciador.Registrar(lauri);
            gerenciador.Registrar(camila);

            Console.WriteLine("");
            Console.WriteLine("Total de bonificações do mês: " +
                gerenciador.GetTotalBonificacao());
        }      

    }
}
