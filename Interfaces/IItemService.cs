using minerals.Models;

namespace minerals.Interfaces
{
    public interface IItemService
    {
        public IEnumerable<Item> GetProducts();
        public Item GetProduct(int id);
    }
}
