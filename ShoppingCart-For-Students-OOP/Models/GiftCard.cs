using ShoppingCart_For_Students_OOP.Contracts;

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
