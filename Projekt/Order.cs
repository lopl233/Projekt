namespace Projekt
{
    public class Order
    {
        public int orderId { get; set; }
        public int userId { get; set; }
        public string status { get; set; }
    
        public string userName { get; set; }

        public Order(int orderId, int userId, string status, string userName)
        {
            this.orderId = orderId;
            this.userId = userId;
            this.status = status;
            this.userName = userName;
        }
    }
}
