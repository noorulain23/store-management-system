using System.Collections.Generic;
using System;
public class Customer
{
    public string name;
    private string phoneNumber;
    public LinkedList<Product> products;
    //public int noOfProducts;

    public Customer(string name, string phoneNumber)
    {
        this.name = name;
        this.phoneNumber = phoneNumber;
        this.products = new LinkedList<Product>();
    }
    public void AddToCart(Product product, Inventory inventory)
    {
        bool isFound = false;
        foreach (Product item in inventory.products)
        {
            if (item == product)
            {
                isFound = true;
                break;
            }
        }
        if(isFound == true)
        {
            this.products.AddLast(product);
        }
        else
        {
            Console.WriteLine($"{product} is not available");
        }
    }
    // public void Discount(Product product)
    // {
    //     if( > 10000)
    // }
}