using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoProjeto.Entities
{
    class Order
    {

        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Order { get; set; }

    }
}
