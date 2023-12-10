using System.ComponentModel.DataAnnotations;

namespace FullCars.Models
{
    public class Client
    {
        [Key]
        public int Id_clt { get; set; }
        public string Gmail { get; set; }
        public string Password { get; set; }
        public string CardNumber { get; set; }

        // Navigation property (foreign key reference)
        /*you can use this navigation property
         to access the list of orders associated with a client*/
        public ICollection<Commande> Commandes { get; set; }
    }
}
