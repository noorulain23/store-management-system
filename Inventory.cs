using System.Collections.Generic;
using System;
public class Inventory
{
    public int totalItemCount;
    public LinkedList<Product> products;

    public Inventory()
    {
        this.products = new LinkedList<Product>();
    }
    public void RemoveProduct(Product product)
    {
        this.products.Remove(product);
    }
    public void RefillProduct(Product product)
    {
        this.products.AddLast(product);
        
    }

}
