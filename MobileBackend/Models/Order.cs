using System.ComponentModel.DataAnnotations;

namespace MobileBackend.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int Amount { get; set; }
    }
}
