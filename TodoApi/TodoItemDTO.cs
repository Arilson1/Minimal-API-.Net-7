namespace TodoApi
{
    public class TodoItemDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }

        public TodoItemDTO() { }
        public TodoItemDTO(Todo TodoItem) =>
            (Id, Name, IsComplete) = (TodoItem.Id, TodoItem.Name, TodoItem.IsComplete);
    }
}
