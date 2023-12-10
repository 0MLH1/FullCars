using FullCars.Data;
using FullCars.Models;
using FullCars.Services;
using Microsoft.AspNetCore.Mvc;

namespace FullCars.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly CartService _cartService;

        public CartController(ApplicationDbContext context, CartService cartService)
        {
            _context = context;
            _cartService = cartService;
        }

        // Index action (display items in the cart)
        public IActionResult Index()
        {
            List<CartItems> cartItems = _cartService.GetCartItems();
            return View(cartItems);
        }

        // Add to Cart action
        public IActionResult AddToCart(int carId)
        {
            _cartService.AddToCart(carId);
            return RedirectToAction("Index");
        }

        // Remove from Cart action
        public IActionResult RemoveFromCart(int carId)
        {
            _cartService.RemoveFromCart(carId);
            return RedirectToAction("Index");
        }
      
    }
}