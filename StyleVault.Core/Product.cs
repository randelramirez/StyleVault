using System;
using System.Collections.Generic;
using System.Text;

namespace StyleVault.Core
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public int VendorId { get; set; }

        public Vendor Vendor { get; set; }

        public ICollection<OrderDetail> OrderDetails {get; set;}
    }
}
