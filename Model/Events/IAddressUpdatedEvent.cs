﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Events
{
    public interface IAddressUpdatedEvent
    {
        public int CustomerId { get; set; }
    }
}