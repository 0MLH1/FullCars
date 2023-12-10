using FullCars.Data;
using FullCars.Models;
using Microsoft.AspNetCore.Mvc;

namespace FullCars.Controllers
{
    public class CarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Car> cars = GetListOfCars();
            return View(cars);
        }

        public IActionResult Details(int id)
        {
            Car car = GetCarById(id);

            if (car == null)
            {
                return NotFound(); 
            }
            return View(car);
        }


        private List<Car> GetListOfCars()
        {
            /*return new List<Car>
            {
              new Car { Id_car = 1, Marque = "Toyota", Price = 25000, Description = "Sedan", N_Stock = 10 },
              new Car { Id_car = 2, Marque = "Honda", Price = 22000, Description = "SUV", N_Stock = 8 },
            };*/
            return _context.Cars.ToList();
        }
        private Car GetCarById(int id)
        {
            //  return GetListOfCars().FirstOrDefault(c => c.Id_car == id);
            return _context.Cars.FirstOrDefault(c => c.Id_car == id);
        }
    }
}

