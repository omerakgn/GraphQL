public class Query
{
    private readonly AppDbContext _dbContext;

    public Query(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Todo> GetTodos(bool? isCompleted)
    {
        var query = _dbContext.Todos.AsQueryable();

        if (isCompleted.HasValue)
        {
            query = query.Where(t => t.IsCompleted == isCompleted.Value);
        }

        return query.ToList();
    }
}
