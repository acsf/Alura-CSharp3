using BitBank.Funcionarios;
using System;

namespace BitBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario,string senha)
        {
            bool userAutenticado = funcionario.Autenticar(senha);

            if (userAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;

            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
