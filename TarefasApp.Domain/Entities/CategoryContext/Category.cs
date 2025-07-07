namespace TarefasApp.Domain.Entities.CategoryContext;

public sealed class Category : BaseEntity
{
    public Category(string name, string description, Guid userId)
    {
        Name = name;
        Description = description;
        UserId = userId;
    }

    public string Name { get; private set; }
    public string Description { get; private set; }
    public Guid UserId { get; private set; }
}