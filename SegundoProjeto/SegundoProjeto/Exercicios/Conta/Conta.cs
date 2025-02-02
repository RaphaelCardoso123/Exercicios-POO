﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoProjeto.Models
{
    // (ABSTRACT) pq ela só serve para ser herdada, as verdadeiras contas nesse caso são...
    //...ContaCorrente e ContaPoupança
    public abstract class Conta 
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        private double Saldo { get; set; }


        //Método (Ação)
        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }
        public void Sacar(double valor)
        {
            if ( valor <= Saldo)
            {
                Saldo = Saldo - valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!!!");
            }
        }


        //Polimorfismo (Virtual)
        public virtual void ExibirTipoDeConta()
        {
            Console.WriteLine("Tipo de conta: "); // Feito separado pq são tipos diferentes de contas
        }
        public virtual void ExibirResumoConta()
        {
            Console.WriteLine($"Correntista: {Nome}.");
            Console.WriteLine($"Número: {Numero}.");
            Console.WriteLine($"Agencia: {Agencia}.");
            Console.WriteLine($"Saldo: {Saldo}.");
        }


    }
}
