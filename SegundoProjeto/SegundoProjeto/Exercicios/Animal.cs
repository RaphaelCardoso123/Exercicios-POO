﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoProjeto.Exercicios
{
    public abstract class Animal
    {
        public string Raca { get; set; }
        public string Tamanho { get; set; }

        /*
        public virtual void EmitirSom()
        {
            Console.WriteLine("Tipo de som:");
        }
        */
        public virtual void ResumoAnimal()
        {
            Console.WriteLine($"Raça: {Raca}");
            Console.WriteLine($"Tamanho: {Tamanho}");
        }

    }
}
