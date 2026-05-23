using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreProject.Models
{
    public class Order
    {

        public int Id { get; set; }
        public string Article { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }

        public int AddressId { get; set; }
        public string Address { get; set; }

        public DateOnly OrderDate { get; set; }
        public DateOnly DeliveryDate { get; set; }




    }
}
