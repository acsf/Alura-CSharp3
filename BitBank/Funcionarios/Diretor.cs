using BitBank.Sistemas;
using System;

namespace BitBank.Funcionarios
{
    public class Diretor : Autenticavel
    {
        
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }      

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
