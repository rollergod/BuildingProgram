using BuildingProgram.Models.Enum;

namespace BuildingProgram.Models
{
    public class Note
    {
        public int Id { get; set; }
        public Priority Priority { get; set; }
        public string Text { get; set; }
        public int BuildingObjectId { get; set; }
        public BuildingObject BuildingObject { get; set; }
    }
}
