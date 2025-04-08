public static class TodoStore
{
    public static List<Todo> Todos = new List<Todo>
    {
        new Todo { Id = Guid.NewGuid(), Title = "Sample Task 1", IsCompleted = false },
        new Todo { Id = Guid.NewGuid(), Title = "Sample Task 2", IsCompleted = true }
    };
}
