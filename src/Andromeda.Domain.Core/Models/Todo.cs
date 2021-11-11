namespace Andromeda.Domain.Core.Models
{
    public class Todo
    {
        public Todo(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Done = false;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Guid Id { get; private init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
