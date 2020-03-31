using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowCherry.DataService.Data.Models
{
    public class Courier
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<GeoArea> CourierGeoAreas { get; set; }
    }
}
