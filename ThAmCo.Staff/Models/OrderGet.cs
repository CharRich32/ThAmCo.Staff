namespace ThAmCo.Staff.Models
{
    public class OrderGet
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string Notes { get; set; } = null!;
        public DateTime UpdatedDate { get; set; }
        public List<Order> OrderDetails { get; set; } = null!;
    }
}