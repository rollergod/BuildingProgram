namespace BuildingProgram.Models
{
    public class Land
    {
        public int Id { get; set; }
        public double Square { get; set; }
        public decimal SellPrice { get; set; }
        public decimal BuyPrice { get; set; }
        public string CadastralNumber { get; set; }
        public int? LandType { get; set; }
        public string Address { get; set; }

        public Organization Owner { get; set; }
        public int OwnerId { get; set; }
    }
}
