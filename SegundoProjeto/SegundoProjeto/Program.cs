using System;
using SegundoProjeto.Entities;
using SegundoProjeto.Entities.Enums;
using SegundoProjeto.Exercicios;
using SegundoProjeto.Models;
using System.Collections.Generic;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Teste

            List<Autor> Autor = new List<Autor>();

            Autor autor1 = new Autor();
            autor1.Nome = "Nome do livro1";
            autor1.Email = "Email do escritor";

            Autor.Add(autor1);

            foreach(Autor obj in Autor)
            {
                Console.WriteLine(Autor);
            }

          




       

        /*
        Exercicio proposto pelo prof. Leonardo Buta - pasta Exercicios 
        //TIPO DE ANIMAIS

        Cachorro cachorro = new Cachorro();
        cachorro.TipoAnimal();
        cachorro.Raca = "Pastor Alemão";
        cachorro.Tamanho = "Grande";
        cachorro.Latir = "AuAuuu!!";
        cachorro.ResumoAnimal();


        Console.WriteLine("");

        Gato gato = new Gato();
        gato.TipoAnimal();
        gato.Raca = "Azul Russo";
        gato.Tamanho = "Médio";
        gato.Miar = "Miaaaau!!";
        gato.ResumoAnimal();

        Console.WriteLine("");

        Passaro passaro = new Passaro();
        passaro.TipoAnimal();
        passaro.Raca = "Andorinha";
        passaro.Tamanho = "Pequeno";
        passaro.Piar = "PiuPiuPiu!!";
        passaro.ResumoAnimal();
        */







        /*
        * Exercicio feito durante as aulas gravadas e checkpoints - pasta Models 

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
        */
































        /*Exercicio UDEMY
        //(1) ENUM (Classe Entities)
        Order order = new Order
        {
            Id = 1200,
            Moment = DateTime.Now,
            Status = OrderStatus.Shipped
        };
        Console.WriteLine(order);
        Console.ReadLine();
        */


        Console.ReadLine();
        }
    }
}
