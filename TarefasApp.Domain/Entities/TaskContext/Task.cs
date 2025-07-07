using TarefasApp.Domain.DTOs.TaskContext;
using TarefasApp.Domain.Entities.CategoryContext;
using TarefasApp.Domain.Entities.UserContext;
using TarefasApp.Domain.Enums.TaskContext;

namespace TarefasApp.Domain.Entities.TaskContext;

public sealed class Task : BaseEntity
{
    public Task() { }

    public Task(TaskParameters task)
    {
        Title = task.Title;
        Description = task.Description;
        CompletionDate = null;
        ExpectedDate = null;
        Priority = task.Priority;
        Status = task.Status;
        CategoryId = task.CategoryId;
        ResponsibleId = task.ResponsibleId;
    }

    public string Title { get; private set; } 
    public string Description { get; private set; }
    public DateTime? CompletionDate { get; private set; }
    public DateTime? ExpectedDate { get; private set; }
    public ETaskPriority Priority { get; private set; }
    public ETaskStatus Status { get; private set; }
    public Guid CategoryId { get; private set; }
    public Guid ResponsibleId { get; private set; }

    #region Mappings

    public User Responsible { get; private set; } = null!;
    public Category Category { get; private set; } = null!;

    #endregion
}