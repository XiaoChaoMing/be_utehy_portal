using test_portal.Domain.Events;
using Microsoft.Extensions.Logging;

namespace test_portal.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("test_portal Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
