﻿using RequestReceiver.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RequestReceiver.Domain.DTO.Order
{
    public class OrderGetDTO : EntityBase
    {        
        public string Number { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
