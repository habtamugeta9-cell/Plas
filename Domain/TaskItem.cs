namespace Plas.Domain;

public sealed class TaskItem
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Title { get; private set; } = string.Empty;
    
    public string? Description { get; private set; }
    
    public bool IsCompleted { get; private set; } 
    
    public DateTimeOffset CreatedAt { get; private set; } = DateTimeOffset.Now;
    
    public DateTimeOffset UpdatedAt { get; private set; } = DateTimeOffset.Now;
    
    
    
    
    
    


}