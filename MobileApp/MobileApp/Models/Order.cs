using SQLite;

namespace MobileApp.Models
{
    public class Order
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int Amount { get; set; }
    }
}
