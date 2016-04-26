using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EntityFramework_Code_First
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Orders> orders;
            using (var context = new Northwind())
            {
                orders = context.Orders.Include(o => o.Customers).ToList();
            }
            foreach (var order in orders)
            {
                Console.WriteLine("CustomerID " + order.CustomerID + " CompanyName " + order.Customers.CompanyName);
            }

            Console.ReadLine();
        }
    }
}
