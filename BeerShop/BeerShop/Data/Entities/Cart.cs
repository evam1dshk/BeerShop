namespace BeerShop.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
