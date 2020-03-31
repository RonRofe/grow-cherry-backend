using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowCherry.DataService.Data.Models
{
    public class Grocery
    {
        public int Id { get; set; }
        public List<GeoArea> geoArea { get; set; }
        public List<GroceryItem> groceryItems { get; set; }
    }
}
