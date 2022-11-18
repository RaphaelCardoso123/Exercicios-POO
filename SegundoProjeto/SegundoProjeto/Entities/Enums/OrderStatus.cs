﻿using System;
using SegundoProjeto.Entities.Enums;

namespace SegundoProjeto.Entities.Enums
{
    enum OrderStatus : int
    {

        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
