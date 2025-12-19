namespace ChatApp.Application.Interfaces.Services;

/// <summary>
/// واجهة خدمة الإشعارات - Notification Service Interface
/// </summary>
public interface INotificationService
{
    Task SendNotificationAsync(Guid userId, string title, string message, CancellationToken cancellationToken = default);
    Task SendNotificationToGroupAsync(Guid groupId, string title, string message, CancellationToken cancellationToken = default);
    Task SendPushNotificationAsync(Guid userId, string title, string message, Dictionary<string, string>? data = null, CancellationToken cancellationToken = default);
}
