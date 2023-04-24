using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingProgram.Models
{
    public class Land
    {
        public int Id { get; set; }
        public double Square { get; set; }
        public decimal SellPrice { get; set; }
        public decimal BuyPrice { get; set; }
        public string CadastralNumber { get; set; }
        public bool IsSold { get; set; }
        public int? LandType { get; set; }
        public string Address { get; set; }

        public Organization Seller { get; set; }
        public int SellerId { get; set; }
        public Organization? Buyer { get; set; }
        public int? BuyerId { get; set;}
    }
}
