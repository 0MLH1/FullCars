using FullCars.Data;
using FullCars.Models;
using FullCars.Services;
using Microsoft.AspNetCore.Mvc;

namespace FullCars.Controllers
{
    public class PurchaseController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly CartService _cartService;
        public IActionResult Index()
        {
            return View();
        }


        private decimal CalculateTotalPrice(List<CartItems> cartItems)
        {
            decimal totalPrice = 0;

            foreach (var cartItem in cartItems)
            {
                totalPrice += (decimal)cartItem.CarPrice * cartItem.nbr_cars_in_card;
            }

            return totalPrice;
        }


        public IActionResult Checkout()
        {
            var cartItems = _cartService.GetCartItems();

            decimal totalPrice = CalculateTotalPrice(cartItems);
            ViewBag.CartItems = cartItems;
            ViewBag.TotalPrice = totalPrice;
            return View();
        }
        [HttpPost]
        public IActionResult ConfirmPurchase(string cardNumber)
        {
            // Implementation to confirm the purchase and generate a bill
            // This action would typically handle the form submission from the checkout page.
            // You may want to process the payment, update the database, and generate a purchase record.
            // Redirect the user to the ViewBill action to display the generated bill.

            // Process the purchase (replace with your actual logic)
            int purchaseId = ProcessPurchase(cardNumber);

            // Redirect the user to the ViewBill action with the generated purchaseId
            return RedirectToAction("ViewBill", new { purchaseId });
        }
        
        private int ProcessPurchase(string cardNumber)
        {
            // You would typically implement payment processing, update the database, and generate a purchase record.
            Random random = new Random();
            int purchaseId = random.Next(1000, 9999);

            // Clear the shopping cart after successful purchase
            _cartService.ClearCart();

            // Return the generated purchaseId
            return purchaseId;
        }


        public IActionResult ViewBill(int purchaseId)
        {
            string purchaseDetails = $"Purchase Details for Purchase ID: {purchaseId}\nTotal Amount: $100.00\nItems: Car1, Car2";
            ViewBag.PurchaseDetails = purchaseDetails;
            return View("ViewBill");
        }
    }
}

