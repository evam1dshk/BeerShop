namespace BeerShop.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Cart Cart { get; set; }
        public int BeerId { get; set; }
        public Beer Beer { get; set; }
        public int Quantity { get; set; }
    }
}
