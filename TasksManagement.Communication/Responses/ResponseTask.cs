using TasksManagement.Communication.Enums;
using TaskStatus = TasksManagement.Communication.Enums.TaskStatus;

namespace TasksManagement.Communication.Responses;

public class ResponseTask
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime EndDate { get; set; }
    public string Description { get; set; } = string.Empty;
    public TaskStatus Status { get; set; }
    public TaskPriority Priority { get; set; }
}
