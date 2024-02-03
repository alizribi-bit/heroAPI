namespace heroAPI.Enteties
{
    public class SuperHero
    {
        public int Id { get; set; }
        public required String Name { get; set; }
        public String FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Place { get; set; } = String.Empty;
    }
}
