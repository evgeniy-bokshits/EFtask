using System;
using System.Collections.Generic;
using System.Linq;
using Task13_EntityFramework.DAL;
using Task13_EntityFramework.DAL.Repositories;

namespace Task13_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderRepository orderRepository = new OrderRepository();
            IEnumerable<Order> orders = orderRepository.GetAll().ToList();

            foreach (var order in orders)
            {
                Console.WriteLine(order.OrderId);
                Console.WriteLine(order.Customer.CompanyName);
            }

            Console.ReadLine();
        }
    }
}
