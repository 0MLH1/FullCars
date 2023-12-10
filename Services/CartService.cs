using System.Collections.Generic;
using System.Linq;
using FullCars.Data; 
using FullCars.Models;

namespace FullCars.Services
{

    public class CartService
    {
        private readonly ApplicationDbContext _context;

        public CartService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CartItems> GetCartItems()
        {
            // Retrieve cart items from the database or a session, as needed
            // Example:
            return _context.CartItems.ToList();
        }

        public void AddToCart(int carId)
        {
            // Add the selected car to the user's cart in the database or a session
            // Example:
            var existingCartItem = _context.CartItems.FirstOrDefault(item => item.CarId == carId);

            if (existingCartItem != null)
            {
                // If the car is already in the cart, you might want to update the quantity or do nothing
                existingCartItem.nbr_cars_in_card += 1;
            }
            else
            {
                // If the car is not in the cart, add a new Cart
                var newCartItem = new CartItems { CarId = carId, nbr_cars_in_card = 1 };
                _context.CartItems.Add(newCartItem);
            }

            _context.SaveChanges();
        }

        public void RemoveFromCart(int carId)
        {
            // Remove the selected car from the user's cart in the database or a session
            // Example:
            var existingCartItem = _context.CartItems.FirstOrDefault(item => item.CarId == carId);

            if (existingCartItem != null)
            {
                // If the car is in the cart, remove it
                _context.CartItems.Remove(existingCartItem);
                _context.SaveChanges();
            }
        }
        public void ClearCart()
        {
            // Remove all items from the cart in the database
            var cartItems = _context.CartItems.ToList();
            _context.CartItems.RemoveRange(cartItems);
            _context.SaveChanges();
        }
    }
}