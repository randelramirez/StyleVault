using System;
using System.Collections.Generic;
using System.Text;

namespace StyleVault.Core
{
    public class Order
    {
        public Order()
        {
            this.OrdersDetails = new List<OrderDetail>();
        }

        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public ICollection<OrderDetail> OrdersDetails { get; set; }

        public Customer Customer { get; set; }

    }
}
