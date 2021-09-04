using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Opcoes
    {
        public static void Escolha()
        {
            Globais.cont = 1;

            Console.WriteLine("" +                
                "1 - Saldo \n" +
                "2 - Saque \n" +
                "3 - Deposito \n" +
                "Digite 0 para SAIR! \n"
                );
        }
    }
}
