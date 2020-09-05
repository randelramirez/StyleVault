using System.Collections.Generic;

namespace StyleVault.Core
{
    public class Vendor
    {
        public Vendor()
        {
            this.Products = new List<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public  ICollection<Product> Products { get; set; }
    }
}
