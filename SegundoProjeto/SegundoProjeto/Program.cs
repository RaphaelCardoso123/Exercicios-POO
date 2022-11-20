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

            //CONTA CORRENTE
            ContaCorrente contaC = new ContaCorrente();

            contaC.Nome = "Raphael Cardoso";
            contaC.Numero = 9999;
            contaC.Agencia = 123;
            contaC.Tarifa = 15;
            contaC.Depositar(1000);  //Por Saldo na classe Conta ser prvado só pode ser alterada dessa maneira.
            contaC.Sacar(900);       //Por Saldo na classe Conta ser prvado só pode ser alterada dessa maneira.
            contaC.ExibirTipoDeConta();  //Usando Polimorfismo
            contaC.ExibirResumoConta();
       

            Console.WriteLine("----------------------");


            //CONTA POUPANÇA
            ContaPoupanca contaP = new ContaPoupanca();

            contaP.Nome = "Flávia Gimmioli";
            contaP.Numero = 8888;
            contaP.Agencia = 321;
            contaP.Juros = 2;
            contaP.Depositar(1200); //Por Saldo na classe Conta ser prvado só pode ser alterada dessa maneira.
            contaP.Sacar(800);      //Por Saldo na classe Conta ser prvado só pode ser alterada dessa maneira.
            contaP.ExibirTipoDeConta();  //Usando Polimorfismo
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
