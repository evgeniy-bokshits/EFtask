using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task13_EntityFramework.DAL.Interfaces;

namespace Task13_EntityFramework.DAL.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private NorthwindDb _context = new NorthwindDb();

        public void Add(Order order)
        {
            using (var context = new NorthwindDb())
            {
                context.Orders.Add(order);

                context.SaveChanges();
            }
        }

        public void Delete(Order order)
        {
            using (var context = new NorthwindDb())
            {
                context.Orders.Remove(order);

                context.SaveChanges();
            }
        }

        public IEnumerable<Order> GetAll()
        {
            using (var context = new NorthwindDb())
            {
                return context.Orders.Include(o => o.Customer).ToList();
            }
        }
    }
}
