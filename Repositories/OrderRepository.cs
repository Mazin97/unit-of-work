using unit_of_work.Data;
using unit_of_work.Models;
using unit_of_work.Repositories.Interfaces;

namespace unit_of_work.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public void Save(Order order)
        {
            _context.Orders.Add(order);
        }
    }
}