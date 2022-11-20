using System;
using SegundoProjeto.Entities;
using SegundoProjeto.Entities.Enums;
using SegundoProjeto.Models;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CONTA CORRENTE:");
            ContaCorrente contaC = new ContaCorrente();

            contaC.Nome = "Raphael Cardoso";
            contaC.Numero = 9999;
            contaC.Agencia = 123;
            contaC.Saldo = 500;
            contaC.Tarifa = 15;
            contaC.Depositar(1000);
            contaC.ExibirResumoConta();

            Console.WriteLine("----------------------");

            Console.WriteLine("CONTA POUPANÇA:");
            ContaPoupanca contaP = new ContaPoupanca();

            contaP.Nome = "Flávia Gimmioli";
            contaP.Numero = 8888;
            contaP.Agencia = 321;
            contaP.Saldo = 1000;
            contaP.Juros = 2;
            contaP.Depositar(1000);
            contaP.ExibirResumoConta();


            Console.ReadLine();






            /*
            //(1) ENUM (Classe Entities) - UDEMY
            Order order = new Order
            {
                Id = 1200,
                Moment = DateTime.Now,
                Status = OrderStatus.Shipped
            };
            Console.WriteLine(order);
            Console.ReadLine();
            */
        }
    }
}
