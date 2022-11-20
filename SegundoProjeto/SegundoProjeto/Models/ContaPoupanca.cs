using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoProjeto.Models
{
    class ContaPoupanca : Conta //Herança (: conta) 
    {
        public double Juros { get; set; }


        //Polimorfismo (Override)
        public override void ExibirResumoConta()
        {
            base.ExibirResumoConta(); // Quando usa (base.) é para chamar dados da "base" neste caso "Conta" + o Juros
            Console.WriteLine($"Juros: {Juros}.");
        }
        public override void ExibirTipoDeConta()
        {
            Console.WriteLine("Conta Poupança."); // Aqui ñ usou (base.) pq é p/ usar somente o "Conta Poupança"
        }


    }
}
