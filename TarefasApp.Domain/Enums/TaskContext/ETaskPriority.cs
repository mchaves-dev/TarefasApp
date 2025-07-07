using System.ComponentModel;

namespace TarefasApp.Domain.Enums.TaskContext;

public enum ETaskPriority
{
    [Description("Baixa")]
    Low = 1,
    [Description("Média")]
    Medium = 2,
    [Description("Alta")]
    High = 3
}