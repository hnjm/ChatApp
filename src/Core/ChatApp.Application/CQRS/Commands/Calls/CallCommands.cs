using MediatR;
using ChatApp.Application.DTOs.Calls;

namespace ChatApp.Application.CQRS.Commands.Calls;

/// <summary>
/// أمر بدء مكالمة - Initiate Call Command
/// </summary>
public record InitiateCallCommand : IRequest<CallDto>
{
    public Guid CallerId { get; init; }
    public Guid ReceiverId { get; init; }
    public required string CallType { get; init; }
    public string? WebRtcOffer { get; init; }
}

/// <summary>
/// أمر قبول مكالمة - Accept Call Command
/// </summary>
public record AcceptCallCommand : IRequest<bool>
{
    public Guid CallId { get; init; }
    public Guid UserId { get; init; }
    public string? WebRtcAnswer { get; init; }
}

/// <summary>
/// أمر رفض مكالمة - Reject Call Command
/// </summary>
public record RejectCallCommand : IRequest<bool>
{
    public Guid CallId { get; init; }
    public Guid UserId { get; init; }
}

/// <summary>
/// أمر إنهاء مكالمة - End Call Command
/// </summary>
public record EndCallCommand : IRequest<bool>
{
    public Guid CallId { get; init; }
    public Guid UserId { get; init; }
}
