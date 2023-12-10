using System.ComponentModel.DataAnnotations;

namespace FullCars.Models
{
    public class Car
    {
        [Key]
        public int Id_car { get; set; }
        public string Marque { get; set; }
        public double Price { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Description { get; set; }
        public int N_Stock { get; set; }

        // Navigation property (foreign key reference)
        /*you can use this navigation property
         to access the list of orders associated with a particular car*/
        public ICollection<Commande> Commandes { get; set; }
    }
}
