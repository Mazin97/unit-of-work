using unit_of_work.Data;
using unit_of_work.Models;
using unit_of_work.Repositories.Interfaces;

namespace unit_of_work.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private DataContext _context;

    public CustomerRepository(DataContext context)
    {
        _context = context;
    }

    public void Save(Customer customer)
    {
        _context.Customers.Add(customer);

    }
}