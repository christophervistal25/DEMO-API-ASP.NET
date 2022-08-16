namespace Inventory.API.Models
{
    public class Product :BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
