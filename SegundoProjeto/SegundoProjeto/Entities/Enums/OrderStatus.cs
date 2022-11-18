using System;
using SegundoProjeto.Entities.Enums

namespace SegundoProjeto.Entities.Enums
{
    class OrderStatus : Int
    {

        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
