using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoProjeto.Exercicios
{
    class Passaro : Animal
    {
        public string Piar { get; set; }

        public override void ResumoAnimal()
        {
            base.ResumoAnimal();
            Console.WriteLine($"Pássaro: {Piar}");
        }
    }
}
