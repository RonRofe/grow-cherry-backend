using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowCherry.DataService.Data.Models
{
    public class ShipmentDetail
    {
        public int Id { get; set; }
        public Grocery Grocery { get; set; }
        public Courier Courier { get; set; }
        public List<GroceryItem> GroceryItems { get; set; }
        public string ShipmentToAddress { get; set; }
        public DateTime ShipmentArrivalTime { get; set; }
        public int ShipmentArrivalTimeOffset { get; set; }
    }
}
