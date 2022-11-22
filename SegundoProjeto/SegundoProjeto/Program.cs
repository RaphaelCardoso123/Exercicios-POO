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
           
            List<Autor> Autores = new List<Autor>();

            //Livro l1 = new Livro();

            Autor autor1 = new Autor();
            autor1.Nome = "The catcher in the Rye";
            autor1.Email = "salinger@gmail.com";
            Autores.Add(autor1);
          
            Autor autor2 = new Autor();
            autor2.Nome = "Rich Dad Poor Dad";
            autor2.Email = "robert@hotmail.com";
            Autores.Add(autor2);

            Autor autor3 = new Autor();
            autor3.Nome = "Richest Man in Babylon";
            autor3.Email = "george@gmail.com";
            Autores.Add(autor3);

            //l1.autores.Add(autor1, autor2, autor3);

            Console.WriteLine("Livros:");
            Console.WriteLine("");

            foreach (Autor obj in Autores)
            {
                Console.WriteLine($"Nome: {obj.Nome}.");
                Console.WriteLine($"Email: {obj.Email}.");
                Console.WriteLine("");
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
