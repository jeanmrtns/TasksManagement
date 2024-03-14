using TasksManagement.Communication.Responses;

namespace TasksManagement.Application.UseCases.Task.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTask Execute(Guid id)
    {
        return new ResponseTask
        {
            Id = id,
            Title = "Task 1",
            Description = "Description 1",
            Status = Communication.Enums.TaskStatus.New,
            EndDate = DateTime.Now.AddDays(1),
            Priority = Communication.Enums.TaskPriority.High
        };
    }
}
