using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoProjeto.Models
{
    class ContaCorrente
    {

        public string Nome { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; set; }
        public double Taxa { get; set; }

        //Método (Ação)
        public void Depositar (double valor)
        {
            Saldo += valor;
        }

    }
}
