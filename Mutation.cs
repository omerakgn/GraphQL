public class Mutation
{
    private readonly AppDbContext _dbContext;

    public Mutation(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Todo AddTodo(string title)
    {
        var todo = new Todo
        {
            Id = Guid.NewGuid(),
            Title = title,
            IsCompleted = false
        };

        _dbContext.Todos.Add(todo);
        _dbContext.SaveChanges(); // Veriyi veritabanına kaydet

        return todo; // Kaydedilen Todo nesnesini döndür
    }


     public bool DeleteTodo(Guid id)
    {
        var todo = _dbContext.Todos.FirstOrDefault(t => t.Id == id);
        if (todo != null)
        {
            _dbContext.Todos.Remove(todo);
            _dbContext.SaveChanges();
            return true;
        }
        return false;
    }
}
