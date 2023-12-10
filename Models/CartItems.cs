using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullCars.Models
{
    public class CartItems
    {
        [Key]
        public long Id { get; set; }
        public int Id_clt { get; set; }
        public int CarId { get; set; }
        public string CarName { get; set; }
        public double CarPrice { get; set; }
        public int nbr_cars_in_card { get; set; }

        [ForeignKey("Id_clt")]
        public Client Client { get; set; }
    }
}
