using ShoppingCart_For_Students_OOP.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_For_Students_OOP.Models
{
    public class GiftCard : IPurchasable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageFileName { get; set; }
        public string RecieverEmailAddress { get; set; }
    }
}
