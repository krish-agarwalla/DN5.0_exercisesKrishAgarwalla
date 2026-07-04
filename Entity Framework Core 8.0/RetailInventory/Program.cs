using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

Console.WriteLine("----- All Products -----");

var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Id}. {p.Name} - ₹{p.Price}");
}

Console.WriteLine();

Console.WriteLine("----- Find Product By ID -----");

var product = await context.Products.FindAsync(1);

if (product != null)
{
    Console.WriteLine($"Found: {product.Name} - ₹{product.Price}");
}
else
{
    Console.WriteLine("Product not found.");
}

Console.WriteLine();

Console.WriteLine("----- First Expensive Product -----");

var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

if (expensive != null)
{
    Console.WriteLine($"Expensive Product: {expensive.Name} - ₹{expensive.Price}");
}
else
{
    Console.WriteLine("No expensive product found.");
}