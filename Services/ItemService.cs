using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using minerals.Data;
using minerals.Interfaces;
using minerals.Models;

namespace minerals.Services
{
    public class ItemService : IItemService
    {
        private readonly AppDbContext _context;

        public ItemService(AppDbContext context)
        {
            _context = context;
        }
        public Item GetProduct(int id)
        {
            return GetProducts().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Item> GetProducts()
        {
            return _context.Items.AsNoTracking().ToList();
        }
    }
}
