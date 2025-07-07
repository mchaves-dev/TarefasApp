using TarefasApp.Domain.Enums.TaskContext;

namespace TarefasApp.Domain.DTOs.TaskContext;

public record class TaskParameters(string Title, 
                                   string Description, 
                                   ETaskPriority Priority, 
                                   ETaskStatus Status, 
                                   Guid CategoryId, 
                                   Guid ResponsibleId);
