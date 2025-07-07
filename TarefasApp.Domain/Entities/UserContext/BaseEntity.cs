namespace TarefasApp.Domain.Entities.UserContext;

public abstract class BaseEntity
{
    public BaseEntity()
    {
        Id = Guid.NewGuid();
        Update_at = null;
        Create_at = DateTime.Now;
    }

    public Guid Id { get; private set; }
    public DateTime? Update_at { get; private set; }
    public DateTime Create_at { get; private set; }
}