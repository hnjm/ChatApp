using ChatApp.Application.DTOs.Media;

namespace ChatApp.Application.DTOs.Messages;

/// <summary>
/// DTO للرسالة - Message DTO
/// </summary>
public record MessageDto
{
    public Guid Id { get; init; }
    public Guid ConversationId { get; init; }
    public Guid SenderId { get; init; }
    public string SenderName { get; init; } = string.Empty;
    public string? SenderProfilePictureUrl { get; init; }
    public string Type { get; init; } = "Text";
    public string? Content { get; init; }
    public Guid? ReplyToMessageId { get; init; }
    public bool IsEdited { get; init; }
    public DateTime? EditedAt { get; init; }
    public bool IsDeletedForEveryone { get; init; }
    public bool IsPinned { get; init; }
    public int ReactionsCount { get; init; }
    public DateTime CreatedAt { get; init; }
    public MediaDto? Media { get; init; }
    public VoiceMessageDto? VoiceMessage { get; init; }
}

/// <summary>
/// DTO لإرسال رسالة - Send Message DTO
/// </summary>
public record SendMessageDto
{
    public Guid ConversationId { get; init; }
    public string Type { get; init; } = "Text";
    public string? Content { get; init; }
    public Guid? ReplyToMessageId { get; init; }
}

/// <summary>
/// DTO لاستجابة الرسالة - Message Response DTO
/// </summary>
public record MessageResponseDto
{
    public Guid MessageId { get; init; }
    public Guid ConversationId { get; init; }
    public DateTime SentAt { get; init; }
    public bool Success { get; init; }
    public string? ErrorMessage { get; init; }
}
