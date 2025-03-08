namespace minerals.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string CartId { get; set; } // Идентификатор корзины (может быть сессионным или привязанным к пользователю)
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }

}
