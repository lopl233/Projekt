using System.Collections.Generic;

namespace Projekt
{
    public class OrderDetails
    {
        public int orderId { get; set; }
        public List<Product> products { get; set; }

        public OrderDetails(int orderId, List<Product> products)
        {
            this.orderId = orderId;
            this.products = products;
        }
    }
}
