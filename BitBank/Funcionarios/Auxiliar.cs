using System;

namespace BitBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Criando AUXILIAR");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
