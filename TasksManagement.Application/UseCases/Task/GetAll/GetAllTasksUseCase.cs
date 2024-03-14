using TasksManagement.Communication.Enums;
using TasksManagement.Communication.Responses;
using TaskStatus = TasksManagement.Communication.Enums.TaskStatus;

namespace TasksManagement.Application.UseCases.Task.GetAll;

public class GetAllTasksUseCase
{
    public ResponseGetAllTasksJson Execute()
    {
        return new ResponseGetAllTasksJson
        {
            Tasks = new List<ResponseTask>
            {
                new ResponseTask
                {
                    Id = Guid.NewGuid(),
                    Title = "Task 1",
                    Description = "Description 1",
                    Status = TaskStatus.New,
                    EndDate = DateTime.Now.AddDays(1),
                    Priority = TaskPriority.High
                },
                new ResponseTask
                {
                    Id = Guid.NewGuid(),
                    Title = "Task 2",
                    Description = "Description 2",
                    Status = TaskStatus.Done,
                    EndDate = DateTime.Now.AddDays(2),
                    Priority = TaskPriority.Medium
                }
            }
        };
    }
}
