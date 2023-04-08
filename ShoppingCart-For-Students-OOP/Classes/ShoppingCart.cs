using System.Collections.ObjectModel;

namespace ShoppingCart_For_Students_OOP.Classes
{
    public class ShoppingCart
    {
        private readonly List<CartItem> _items;

        public IReadOnlyCollection<CartItem> Items
        {
            get
            {
                return new ReadOnlyCollection<CartItem>(_items);
            }
        }

        public CartItem this[string name]
        {
            get
            {
                return _items.FirstOrDefault(x => x.Item.Name == name)!;
            }
        }

        public CartItem this[int index]
        {
            get
            {
                return _items[index];
            }
        }

        public ShoppingCart()
            => _items = new List<CartItem>();

        public void AddItem(CartItem item)
            => _items.Add(item);

        public void ClearCart()
            => _items.Clear();

        public void RemoveItem(CartItem item)
            => _items.Remove(item);

        public double Total
        {
            get
            {
                double total = 0;
                foreach (var item in _items)
                    total += item.Item.Price * item.Quantity;

                return total;
            }
        }
    }
}
