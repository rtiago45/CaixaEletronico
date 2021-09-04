using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Saldo
    {
        public double MeuSaldo
        {
            get 
            {
                return Globais.saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                Globais.saldo = value;
            }
        }
    }
}
