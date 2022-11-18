using System;
using SegundoProjeto.Entities;
using SegundoProjeto.Entities.Enums;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {

                Id = 1200,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered


            };
            Console.WriteLine(order);
            Console.ReadLine();
        }
    }
}
