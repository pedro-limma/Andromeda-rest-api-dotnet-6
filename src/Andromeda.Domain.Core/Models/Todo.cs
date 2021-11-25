namespace Andromeda.Domain.Core.Models
{
    public class Todo
    {
        public Todo(string name)
        {
            Name = name;
            Done = false;
            UpdatedAt = DateTime.UtcNow.ToString();
        }

        public int Id { get; private init; }
        public string Name { get; set; }
        public bool Done { get; set; }
        public string UpdatedAt { get; set; }
    }
}
