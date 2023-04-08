namespace ShoppingCart_For_Students_OOP.Contracts
{
    public interface IPurchasable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageFileName { get; set; }

    }
}
