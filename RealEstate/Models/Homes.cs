using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models
{
    public class Homes
    {
        public int Id { get; set; }
        public string HouseImageUrl { get; set; }
        public string HouseImageUrl1 { get; set; }
        public string HouseImageUrl2 { get; set; }
        public string HouseImageUrl3 { get; set; }
        public string HouseImageUrl4 { get; set; }
        public string HouseImageUrl5 { get; set; }
        public string HouseImageUrl6 { get; set; }

        public int Price { get; set; }
        public int EstMortgage { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }

        public string Type { get; set; }
        public int YearBuilt { get; set; }
        

    }
}
