namespace TasksProject.Data.Data.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? Description { get; set; } = string.Empty;
        public User Author { get; set; }
        public List<User> Executors { get; set; } = new List<User>();
    }
}
