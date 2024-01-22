namespace ToDoAPI.Model
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; } = DateTime.Now;
        public bool isFineshed { get; set; } = false;
    }
}
