namespace unit_of_work.Models
{
    public class Order
    {
        public Order(string number, Customer customer)
        {
            Number = number;
            Customer = customer;
        }

        public int Id { get; private set; }

        public string Number { get; private set; }

        public int CustomerId { get; private set; }

        public Customer Customer { get; private set; }
    }
}