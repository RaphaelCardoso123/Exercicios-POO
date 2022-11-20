using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoProjeto.Models
{
    class ContaPoupanca
    {

        public string Nome { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; set; }
        public double Juros { get; set; }

        //Método (Ação)
        public void Depositar (double valor)
        {
            Saldo += valor;
        }

        public void ExibirResumoConta()
        {
            Console.WriteLine($"Correntista: {Nome}.");
            Console.WriteLine($"Número: {Numero}.");
            Console.WriteLine($"Agencia: {Agencia}.");
            Console.WriteLine($"Saldo: {Saldo}.");
        }

    }
}
