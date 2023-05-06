namespace BuildingProgram.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; } = false;

        // TODO : показывать только свои объекты
        public ICollection<BuildingObject> BuildingObjects { get; set; }
    }
}
