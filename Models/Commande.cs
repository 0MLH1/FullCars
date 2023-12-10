using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullCars.Models
{
    public class Commande
    {
        [Key]
        public int Id_commande { get; set; }
        public DateTime Date_com { get; set; }

        // Foreign key references
        [ForeignKey("Client")]
        public int Id_clt { get; set; }
        [ForeignKey("Car")]
        public int Id_car { get; set; }

        // Navigation properties (references to related entities)
        /*Here, Client and Car are navigation properties. 
         These properties represent the relationships between Commande and Client as well as Commande and Car .
         Access the associated client information
         var clientInfo = commande.Client; 
        Access the associated car information
        var carInfo = commande.Car;*/
        public Client Client { get; set; }
        public Car Car { get; set; }
    }
}
