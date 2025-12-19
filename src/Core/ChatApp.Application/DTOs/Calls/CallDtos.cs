namespace ChatApp.Application.DTOs.Calls;

/// <summary>
/// DTO للمكالمة - Call DTO
/// </summary>
public record CallDto
{
    public Guid Id { get; init; }
    public Guid ConversationId { get; init; }
    public Guid CallerId { get; init; }
    public string CallerName { get; init; } = string.Empty;
    public Guid ReceiverId { get; init; }
    public string ReceiverName { get; init; } = string.Empty;
    public string Type { get; init; } = "Voice";
    public string Status { get; init; } = "Initiating";
    public DateTime? StartedAt { get; init; }
    public DateTime? EndedAt { get; init; }
    public int? Duration { get; init; }
    public DateTime CreatedAt { get; init; }
}

/// <summary>
/// DTO لبدء مكالمة - Initiate Call DTO
/// </summary>
public record InitiateCallDto
{
    public Guid ReceiverId { get; init; }
    public string Type { get; init; } = "Voice";
    public string? WebRtcOffer { get; init; }
}

/// <summary>
/// DTO لحالة المكالمة - Call Status DTO
/// </summary>
public record CallStatusDto
{
    public Guid CallId { get; init; }
    public string Status { get; init; } = "Initiating";
    public string? WebRtcAnswer { get; init; }
    public DateTime UpdatedAt { get; init; }
}
