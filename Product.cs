using System;

public class Product
{
	public string Name { get; }
	public int Price { get; }
	public double Weight { get; }
	public Product(string name, int price, double weight)
	{
		Name = name;
		Price = price;
		Weight = weight;
	}
}
