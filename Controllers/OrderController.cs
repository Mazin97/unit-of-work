using Microsoft.AspNetCore.Mvc;
using unit_of_work.Data.Interfaces;
using unit_of_work.Models;
using unit_of_work.Repositories.Interfaces;

namespace unit_of_work.Controllers;

[ApiController]
[Route("v1/orders")]
public class OrderController : ControllerBase
{
    [HttpPost]
    [Route("")]
    public Order Post(
        [FromServices] ICustomerRepository customerRepository,
        [FromServices] IOrderRepository orderRepository,
        [FromServices] IUnitOfWork uow
    )
    {
        try
        {
            var customer = new Customer("Mateus Bertolazo");
            var order = new Order("123", customer);

            customerRepository.Save(customer);
            orderRepository.Save(order);

            uow.Commit();

            return order;
        }
        catch
        {
            uow.Rollback();
            return null;
        }
    }
}