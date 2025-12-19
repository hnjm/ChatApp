using ChatApp.Application.DTOs.Messages;

namespace ChatApp.Application.Interfaces.Services;

/// <summary>
/// واجهة خدمة الرسائل - Message Service Interface
/// </summary>
public interface IMessageService
{
    Task<MessageDto?> GetMessageByIdAsync(Guid messageId, CancellationToken cancellationToken = default);
    Task<List<MessageDto>> GetConversationMessagesAsync(Guid conversationId, int pageNumber, int pageSize, CancellationToken cancellationToken = default);
    Task<MessageResponseDto> SendTextMessageAsync(Guid senderId, Guid conversationId, string content, Guid? replyToMessageId = null, CancellationToken cancellationToken = default);
    Task<bool> EditMessageAsync(Guid messageId, Guid userId, string newContent, CancellationToken cancellationToken = default);
    Task<bool> DeleteMessageAsync(Guid messageId, Guid userId, bool deleteForEveryone, CancellationToken cancellationToken = default);
    Task<List<MessageDto>> SearchMessagesAsync(Guid conversationId, string searchTerm, int pageNumber, int pageSize, CancellationToken cancellationToken = default);
}
