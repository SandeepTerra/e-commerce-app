using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_app.Models
{
    public class Basket
    {
        public int ID { get; set; }
        public string CustomerEmail { get; set; } //this will be tied to user email
        public List<BasketItem> BasketItems { get; set; }

        public Basket()
        {
            BasketItems = new List<BasketItem>();
        }
    }
}
