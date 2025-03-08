using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using minerals.Data;
using minerals.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

[Authorize]
public class CartController : Controller
{
    private readonly AppDbContext _context;
    public CartController(AppDbContext context)
    {
        _context = context;
    }

    // Получаем или создаём уникальный идентификатор корзины и сохраняем его в сессии
    private string GetCartId()
    {
        if (HttpContext.Session.GetString("CartId") == null)
        {
            HttpContext.Session.SetString("CartId", Guid.NewGuid().ToString());
        }
        return HttpContext.Session.GetString("CartId");
    }

    // Отображение корзины
    public async Task<IActionResult> Cart()
    {
        string cartId = GetCartId();
        var cartItems = await _context.CartItems
                             .Include(ci => ci.Item)
                             .Where(ci => ci.CartId == cartId)
                             .ToListAsync();
        ViewBag.Total = cartItems.Sum(ci => ci.Quantity * ci.Item.Price);
        return View(cartItems);
    }

    // Добавление товара в корзину
    [HttpPost]
    public async Task<IActionResult> Add(int itemId)
    {
        string cartId = GetCartId();
        var cartItem = await _context.CartItems
                         .FirstOrDefaultAsync(ci => ci.CartId == cartId && ci.ItemId == itemId);
        if (cartItem != null)
        {
            cartItem.Quantity++;
        }
        else
        {
            var item = await _context.Items.FindAsync(itemId);
            if (item == null)
                return NotFound();

            cartItem = new CartItem
            {
                CartId = cartId,
                ItemId = itemId,
                Quantity = 1
            };
            _context.CartItems.Add(cartItem);
        }
        await _context.SaveChangesAsync();
        return RedirectToAction("Cart");
    }

    // Удаление товара из корзины
    [HttpPost]
    public async Task<IActionResult> Remove(int cartItemId)
    {
        string cartId = GetCartId();
        var cartItem = await _context.CartItems
                          .FirstOrDefaultAsync(ci => ci.CartId == cartId && ci.Id == cartItemId);
        if (cartItem != null)
        {
            _context.CartItems.Remove(cartItem);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction("Cart");
    }

    // Обновление количества товара в корзине
    [HttpPost]
    public async Task<IActionResult> Update(int cartItemId, int quantity)
    {
        string cartId = GetCartId();
        var cartItem = await _context.CartItems
                          .FirstOrDefaultAsync(ci => ci.CartId == cartId && ci.Id == cartItemId);
        if (cartItem != null)
        {
            if (quantity <= 0)
                _context.CartItems.Remove(cartItem);
            else
                cartItem.Quantity = quantity;

            await _context.SaveChangesAsync();
        }
        return RedirectToAction("Cart");
    }
}
