using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Deposito

    {
        public double MeuDeposito
        {
            get
            {
                return Globais.saldo;
            }
            set
            {
                if (Globais.deposito < 0)
                {
                    return;
                }
                Globais.saldo += Globais.deposito;
            }
        }
    }
}
