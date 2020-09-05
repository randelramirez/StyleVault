using StyleVault.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Helpers
{
    public class DataInitializer
    {
        private readonly StyleVaultContext context;

        public DataInitializer(StyleVaultContext context) => this.context = context;

        public void SeedVendorProducts()
        {
            this.SeedVendors();
            this.SeedProducts();
        }

        private void SeedVendors()
        {
            var vendors = new List<Vendor>()
            {
                new Vendor { Name = "Nike" },
                new Vendor { Name = "Obey" },
                new Vendor { Name = "Adidas" },
                new Vendor { Name = "SSUR" },
                new Vendor { Name = "Asics" },
                new Vendor { Name = "New Balance" },
            };

            //vendors.ForEach(v => context.Add(v));
            this.context.AddRange(vendors);
            this.context.SaveChanges();
        }

        private void SeedProducts()
        {
            var products = new List<Product>
            {
                //NIKE
                new Product { Name = "Kobe AD Big Stage", Price = 10_000, Description = "White and Gold", VendorId = 1 },
                new Product { Name = "Kobe AD Mid Black/Gold", Price = 10_500, Description = "Mid cut, Black and Gold", VendorId = 1 },
                new Product { Name = "Kobe 5 Protro Big Stage Parade", Price = 11_000, Description = "White and Gold Protro", VendorId = 1 },

                //OBEY
                new Product { Name = "Logo Long Sleeve T-Shirt Burgundy", Price = 4500, Description = "Long Sleeve Shirt, Burgundy", VendorId = 2 },
                new Product { Name = "Era Long Sleeve T-shirt", Price = 2000, Description = "Long Sleeve T-shirt", VendorId = 2 },

                //ADIDAS
                new Product { Name = "Harden VOL. 3 Red", Price = 8500, Description = "Harden Vol. 3",  VendorId = 3 },
                new Product { Name = "Ultraboost 2020 Vapour Pink", Price = 9700, Description = "Ultraboost 2020 Vapour Pink", VendorId = 3 },

                //SSUR
                new Product { Name = "New York Cap", Price = 3000, Description = "Black SSUR Cap", VendorId = 4 },

                //ASICS
                new Product { Name = "Nippon Blues", Price = 13_000, Description = "Gel Lyte 3", VendorId = 5 },
                new Product { Name = "Aztec", Price = 6000, Description = "Gel Lyte 3", VendorId = 5 },
                new Product { Name = "Brazil", Price = 5000, Description = "Gel Lyte 5 Brazil Pack",  VendorId = 5 },
                new Product { Name = "Honey Mustard", Price = 7000, Description = "Gel Lyte 3", VendorId = 5 },

            };

            //products.ForEach(p => context.Add(p));
            this.context.AddRange(products);
            this.context.SaveChanges();
        }

    }
}
