using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{

    class Sacar 
    {
        public double Saque
        {
            get
            {
                return Globais.saldo;
            }
            set
            {
                if(Globais.retirada > Globais.saldo)
                {
                    return;
                }
                else
                {
                    Globais.saldo -= Globais.retirada;
                }
            }
        }
    }
}
