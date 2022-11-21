using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoProjeto.Exercicios
{
    class Gato : Animal
    {
        public string Miar { get; set; }

        public override void ResumoAnimal()
        {
            base.ResumoAnimal();
            Console.WriteLine($"Gato: {Miar}");
        }
        public override void TipoAnimal()
        {
            Console.WriteLine("Gato:");
        }
    }

    
}
