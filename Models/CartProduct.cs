namespace OnlineStore.Models
{
    public class CartProduct
    {
        public int Id { get; set; }
        public int IdCart { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
