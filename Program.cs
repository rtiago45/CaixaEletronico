using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Globais globais = new Globais();

            // Definindo valores da Conta!
            Saldo saldo = new Saldo();
            Sacar sacar = new Sacar();
            Deposito deposito = new Deposito();
            //saldo.MeuSaldo = 1000;
            Console.WriteLine("*******MENU PRINCIPAL*******");

            while (Globais.cont != 0)

            {
                Console.WriteLine("Caixa eletrônico, escolha sua opção: ");
                Linha._linha();
                Console.WriteLine("");
                Opcoes.Escolha();
                Globais.cont = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (Globais.cont)
                {
                    case 1:
                        Console.WriteLine("Defina seu saldo inicial: ");
                        Globais.saldo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("O seu saldo é: " + Globais.saldo);
                        Linha._pulaLinha();
                        continue;
                    case 2:
                        Console.WriteLine("O seu saldo é: " + Globais.saldo + " Quanto deseja sacar? \n");
                        Globais.retirada = Convert.ToInt32(Console.ReadLine());
                        Linha._pulaLinha();
                        sacar.Saque = Globais.retirada;
                        Console.WriteLine("Seu novo saldo é: " + Globais.saldo);                        
                        Linha._pulaLinha();
                        continue;
                    case 3:
                        Console.WriteLine("Qual o valor do seu depósito: ");
                        Globais.deposito = Convert.ToInt32(Console.ReadLine());
                        Linha._pulaLinha();
                        deposito.MeuDeposito = Globais.deposito;
                        Console.WriteLine("Seu novo saldo é: " + Globais.saldo);
                        Linha._pulaLinha();

                        continue;
                    default:
                        break;
                }                  
            }
            Console.ReadKey();
        }
    }
}
