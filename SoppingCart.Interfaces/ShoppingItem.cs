﻿
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SoppingCart.Interfaces
{
    [DataContract]
    public class ShoppingItem
    {
        [DataMember]
        public string ShoppingItemCategory { get; set; }

    }
}
