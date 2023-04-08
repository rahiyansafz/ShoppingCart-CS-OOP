using ShoppingCart_For_Students_OOP.Classes;
using ShoppingCart_For_Students_OOP.Models;

var cart = new ShoppingCart();

cart.AddItem(new CartItem(new Product
{
    Name = "Laptop",
    Price = 100,
    ImageFileName = "laptop.jpg"
}));
cart.AddItem(new CartItem(new Product
{
    Name = "Ram",
    Price = 500,
    ImageFileName = "ram.jpg"
}));
cart.AddItem(new CartItem(new GiftCard
{
    Name = "Processor",
    Price = 50,
    ImageFileName = "processor.jpg"
}));

// cart["Laptop"].UpdateQuantity(5);

foreach (var item in cart.Items)
    Console.WriteLine($"Product: {item.Item.Name}, Qty: {item.Quantity}, PPU: {item.Item.Price}");

Console.WriteLine($"Total Price: {cart.Total}");