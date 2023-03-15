using System;
using System.Collections.Generic;

namespace store_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("Wallmart", "Eastside street: 12");
            Customer customer1 = new Customer("joseph", "03121374732");
            Customer customer2 = new Customer("Amna", "03121374732");
            Employee employee1 = new Employee("Ahsan");
            Inventory inventory = new Inventory();
            MakeupProduct makeupProduct1 = new MakeupProduct("Eyeshades", "5gm", "24-Nov-2024", 1500, 2000);
            SkinCareProduct skinCareProduct1 = new SkinCareProduct("Herbal Soap", "5gm", "17-Aug-2025", 2500, 3000);
            Fragrance fragrance1 = new Fragrance("Dior", "100ml", "29-Dec-2026", 24000, 26000);
            Fragrance fragrance2 = new Fragrance("Chanel", "100ml", "10-Dec-2026", 42000, 45000);

            //store.AddCustomer(customer1);
            store.customers.AddFirst(customer1);
            store.customers.AddLast(customer2);
            store.employee.AddFirst(employee1);

            inventory.products.AddFirst(makeupProduct1);
            inventory.products.AddLast(skinCareProduct1);
            inventory.products.AddLast(fragrance1);
            inventory.products.AddLast(fragrance2);

            store.AddInventory(inventory);

            customer1.AddToCart(makeupProduct1, inventory);
            customer1.AddToCart(fragrance1, inventory);

            store.CheckOut(customer1);

            customer2.AddToCart(skinCareProduct1, inventory);
            customer2.AddToCart(fragrance1, inventory);
            store.CheckOut(customer2);

            inventory.RefillProduct(fragrance1);
            customer2.AddToCart(fragrance1, inventory);
            store.CheckOut(customer2);
            store.TotalProfit();






        }
    }
}
