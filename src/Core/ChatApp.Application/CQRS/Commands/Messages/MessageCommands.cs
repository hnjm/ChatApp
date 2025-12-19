using MediatR;
using ChatApp.Application.DTOs.Messages;

namespace ChatApp.Application.CQRS.Commands.Messages;

/// <summary>
/// أمر إرسال رسالة نصية - Send Text Message Command
/// </summary>
public record SendTextMessageCommand : IRequest<MessageResponseDto>
{
    public Guid SenderId { get; init; }
    public Guid ConversationId { get; init; }
    public required string Content { get; init; }
    public Guid? ReplyToMessageId { get; init; }
}

/// <summary>
/// أمر إرسال رسالة إعلامية - Send Media Message Command
/// </summary>
public record SendMediaMessageCommand : IRequest<MessageResponseDto>
{
    public Guid SenderId { get; init; }
    public Guid ConversationId { get; init; }
    public required string MediaType { get; init; }
    public required string FileUrl { get; init; }
    public string? Caption { get; init; }
    public Guid? ReplyToMessageId { get; init; }
}

/// <summary>
/// أمر إرسال رسالة صوتية - Send Voice Message Command
/// </summary>
public record SendVoiceMessageCommand : IRequest<MessageResponseDto>
{
    public Guid SenderId { get; init; }
    public Guid ConversationId { get; init; }
    public required string AudioUrl { get; init; }
    public int Duration { get; init; }
    public string? WaveformData { get; init; }
}

/// <summary>
/// أمر تعديل رسالة - Edit Message Command
/// </summary>
public record EditMessageCommand : IRequest<bool>
{
    public Guid MessageId { get; init; }
    public Guid UserId { get; init; }
    public required string NewContent { get; init; }
}

/// <summary>
/// أمر حذف رسالة - Delete Message Command
/// </summary>
public record DeleteMessageCommand : IRequest<bool>
{
    public Guid MessageId { get; init; }
    public Guid UserId { get; init; }
    public bool DeleteForEveryone { get; init; }
}
