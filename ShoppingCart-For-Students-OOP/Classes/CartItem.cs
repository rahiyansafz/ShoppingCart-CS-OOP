using ShoppingCart_For_Students_OOP.Contracts;

namespace ShoppingCart_For_Students_OOP.Classes
{
    public class CartItem
    {
        public IPurchasable Item { get; private set; }
        public uint Quantity { get; private set; }

        public CartItem(IPurchasable item)
        {
            Item = item;
            Quantity = 1;
        }

        public void UpdateQuantity(uint quantity)
        {
            if (quantity == 0)
                throw new InvalidOperationException("Quantity can't be Zero!");

            Quantity = quantity;
        }
    }
}
