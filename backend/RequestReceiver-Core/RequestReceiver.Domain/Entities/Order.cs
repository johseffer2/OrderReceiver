﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RequestReceiver.Domain.Entities
{
    public class Order: EntityBase
    {      
        public virtual IList<OrderItem> OrderItems { get; set; }
    }
}