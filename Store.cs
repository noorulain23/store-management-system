using System;
using System.Collections.Generic;
class Store
{
    public string name;
    public string location;
    public Inventory inventory;
    public LinkedList<Employee> employee = new LinkedList<Employee>();
    public LinkedList<Customer> customers = new LinkedList<Customer>();
    //public int noOfEmployees;
    //public Employee[] employees;
    //public Customer[] customers;
    // public int noOfCustomers;
    //public Product[] products;
    //public int noOfProducts;
    public int totalProfit;

    public Store(string name, string location)
    {
        this.name = name;
        this.location = location;
        // this.employees = new Employee[2];
        //this.customers = new Customer[5];
        //this.products = new Product[50];
    }
    private void PrintBill(LinkedList<Product> products)
    {
        Console.WriteLine($"{this.name}");
        Console.WriteLine($"Purchased Items                     Price");
        int totalAmount = 0;
        int AmountAfterDiscount = 0;
        int discount = 0;
        foreach (Product item in products)
        {
            totalAmount = totalAmount + item.sellingPrice;

            Console.WriteLine($"{item.productName}:      {item.sellingPrice}");
        }
        Console.WriteLine($"TotalBill: {totalAmount}");
        if (totalAmount > 10000)
        {
            discount = 1000;
            AmountAfterDiscount = totalAmount - discount;
            
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Amount after discount is: {AmountAfterDiscount}");
        }
    }
    public void CheckOut(Customer customer)
    {
        foreach (Product item in customer.products)
        {
            totalProfit = totalProfit + item.NetProfit();
        }
        this.PrintBill(customer.products);

        foreach (Product item in customer.products)
        {
            inventory.products.Remove(item);
        }
        customer.products = new LinkedList<Product>();
    }
    public void TotalProfit()
    {
        Console.WriteLine($"Total profit of the store is: {totalProfit}");
    }


    // public void AddCustomer(Customer customer)
    // {
    //     this.customers[noOfCustomers] = customer;
    //     noOfCustomers++;
    // }
    // public void AddEmployee(Employee employee)
    // {
    //     this.employees[noOfEmployees] = employee;
    //     noOfEmployees++;
    // }
    public void AddInventory(Inventory inventory)
    {
        this.inventory = inventory;
    }

    // public void AddProduct(Product product)
    // {
    //     this.products[noOfProducts] = product;
    //     noOfProducts++;
    // }

}