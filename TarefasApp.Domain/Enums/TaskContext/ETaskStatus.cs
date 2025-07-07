using System.ComponentModel;

namespace TarefasApp.Domain.Enums.TaskContext;

public enum ETaskStatus
{
    [Description("Pendente")]
    Pending = 1,
    [Description("Em Andamento")]
    InProgress = 2,
    [Description("Concluída")]
    Completed = 3,
    [Description("Cancelada")]
    Canceled = 4
}
