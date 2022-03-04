namespace Andromeda.Domain.Core.Models
{
    public class Todo
    {
        public Todo(string name, bool isDone)
        {
            Name = name;
            Done = isDone;
            UpdatedAt = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public int Id { get; private init; }
        public string Name { get; set; }
        public bool Done { get; set; }
        public string UpdatedAt { get; set; }
    }
}
