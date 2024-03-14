using TasksManagement.Communication.Requests;
using TasksManagement.Communication.Responses;

namespace TasksManagement.Application.UseCases.Task.Create;

public class CreateTaskUseCase
{
    public ResponseCreatedTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseCreatedTaskJson
        {
            Id = Guid.NewGuid()
        };
    }
}
