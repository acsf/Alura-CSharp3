﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando GERENTE DE CONTA");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
