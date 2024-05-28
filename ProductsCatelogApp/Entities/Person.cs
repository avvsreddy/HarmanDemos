namespace ProductsCatelogApp.Entities
{
    abstract public class Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
    }
}
