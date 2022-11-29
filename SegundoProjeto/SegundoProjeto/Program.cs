using System;
using SegundoProjeto.Exercicios;
using SegundoProjeto.Entities; 
using SegundoProjeto.Entities.Enums;
using System.Collections.Generic;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //LIVROS

            Livro livro1 = new Livro();
            livro1.NomeLivro = "The catcher in the Rye";
            Livro livro2 = new Livro();
            livro2.NomeLivro = "Rich Dad Poor Dad";
            Livro livro3 = new Livro();
            livro3.NomeLivro = "Richest Man in Babylon";
            

            Autor autor1 = new Autor();
            autor1.Nome = "J. D. Salinger";
            autor1.Email = "salinger@gmail.com";

            Autor autor2 = new Autor();
            autor2.Nome = "Robert Kiyosaki";
            autor2.Email = "robert@hotmail.com";

            Autor autor3 = new Autor();
            autor3.Nome = "George Samuel Clason ";
            autor3.Email = "george@gmail.com";
            

            livro1.Autores.Add(autor1);
            livro2.Autores.Add(autor2);
            livro3.Autores.Add(autor3);

        
            Console.WriteLine("Livros:");
            Console.WriteLine("");

                Console.WriteLine(livro1.NomeLivro);
                foreach (Autor obj in livro1.Autores)
                {
                    Console.WriteLine($"Autor: {obj.Nome}.");
                    Console.WriteLine($"Email: {obj.Email}.");
                    Console.WriteLine("");
                }

                Console.WriteLine(livro2.NomeLivro);
                foreach (Autor obj in livro2.Autores)
                {
                    Console.WriteLine($"Autor: {obj.Nome}.");
                    Console.WriteLine($"Email: {obj.Email}.");
                    Console.WriteLine("");
                }

                Console.WriteLine(livro3.NomeLivro);
                foreach (Autor obj in livro3.Autores)
                {
                    Console.WriteLine($"Autor: {obj.Nome}.");
                    Console.WriteLine($"Email: {obj.Email}.");
                    Console.WriteLine("");
                }
                
            





            /*
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
            //CONTA CORRENTE

            ContaCorrente contaC = new ContaCorrente();

            contaC.Nome = "Raphael Cardoso";
            contaC.Numero = 9999;
            contaC.Agencia = 123;
            contaC.Tarifa = 15;
            contaC.Depositar(1000);  //pelo Saldo na classe Conta ser privado só pode ser alterada dessa maneira.
            contaC.Sacar(900);       //pelo Saldo na classe Conta ser privado só pode ser alterada dessa maneira.
            contaC.ExibirTipoDeConta();  //Usando Polimorfismo
            contaC.ExibirResumoConta();


            Console.WriteLine("----------------------");


            //CONTA POUPANÇA
            ContaPoupanca contaP = new ContaPoupanca();

            contaP.Nome = "Flávia Gimmioli";
            contaP.Numero = 8888;
            contaP.Agencia = 321;
            contaP.Juros = 2;
            contaP.Depositar(1200); //pelo Saldo na classe Conta ser privado só pode ser alterada dessa maneira.
            contaP.Sacar(800);      //pelo Saldo na classe Conta ser privado só pode ser alterada dessa maneira.
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
