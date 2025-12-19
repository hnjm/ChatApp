using ChatApp.Application.DTOs.Calls;

namespace ChatApp.Application.Interfaces.Services;

/// <summary>
/// واجهة خدمة المكالمات - Call Service Interface
/// </summary>
public interface ICallService
{
    Task<CallDto> InitiateCallAsync(Guid callerId, Guid receiverId, string callType, string? webRtcOffer = null, CancellationToken cancellationToken = default);
    Task<bool> AcceptCallAsync(Guid callId, Guid userId, string? webRtcAnswer = null, CancellationToken cancellationToken = default);
    Task<bool> RejectCallAsync(Guid callId, Guid userId, CancellationToken cancellationToken = default);
    Task<bool> EndCallAsync(Guid callId, Guid userId, CancellationToken cancellationToken = default);
    Task<CallDto?> GetCallByIdAsync(Guid callId, CancellationToken cancellationToken = default);
}
