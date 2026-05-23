using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreProject.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Article { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int SupplierId { get; set; }
        public string Supplier { get; set; }
        public int ProducerId { get; set; }
        public string Producer { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public int Discount { get; set; }
        public int InStock { get; set; }
        public string Description { get; set; }
        public string PhotoName { get; set; }

        public string Unit { get; set; }

        public string FullName => $"{Category} | {Name}";

        //public Image GetImage()
        //{
        //    var PhotoPath = Path.Combine(Application.StartupPath, "Pictures", PhotoName);
        //    return new Bitmap(PhotoPath);
        //}

        public Image GetImage()
        {
            var path = Path.Combine(Application.StartupPath, "Pictures", PhotoName);

           return Image.FromFile(path);
            
        }

        public decimal NewPrice()
        {
            decimal newPrice = Price - (Price * Discount) / 100;
            return newPrice;
        }

    }
}
