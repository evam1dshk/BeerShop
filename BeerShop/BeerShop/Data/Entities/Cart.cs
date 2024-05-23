namespace BeerShop.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int BeerId { get; set; }
        public Beer Beer { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal FinalPrice { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
       
    }
}
