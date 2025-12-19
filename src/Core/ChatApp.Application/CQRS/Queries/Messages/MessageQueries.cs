using MediatR;
using ChatApp.Application.DTOs.Messages;

namespace ChatApp.Application.CQRS.Queries.Messages;

/// <summary>
/// استعلام للحصول على الرسائل - Get Messages Query
/// </summary>
public record GetMessagesQuery : IRequest<List<MessageDto>>
{
    public Guid ConversationId { get; init; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 50;
    public DateTime? BeforeDate { get; init; }
}

/// <summary>
/// استعلام للحصول على رسالة معينة - Get Message By Id Query
/// </summary>
public record GetMessageByIdQuery : IRequest<MessageDto?>
{
    public Guid MessageId { get; init; }
}

/// <summary>
/// استعلام البحث في الرسائل - Search Messages Query
/// </summary>
public record SearchMessagesQuery : IRequest<List<MessageDto>>
{
    public Guid ConversationId { get; init; }
    public required string SearchTerm { get; init; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 20;
}
