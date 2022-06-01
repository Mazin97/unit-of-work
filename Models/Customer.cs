namespace unit_of_work.Models
{
    public class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }
    }
}