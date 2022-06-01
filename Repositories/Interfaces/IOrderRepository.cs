using unit_of_work.Models;

namespace unit_of_work.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}