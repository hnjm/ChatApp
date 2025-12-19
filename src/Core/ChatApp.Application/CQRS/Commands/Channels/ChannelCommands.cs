using MediatR;
using ChatApp.Application.DTOs.Channels;

namespace ChatApp.Application.CQRS.Commands.Channels;

/// <summary>
/// أمر إنشاء قناة - Create Channel Command
/// </summary>
public record CreateChannelCommand : IRequest<ChannelDto>
{
    public Guid CreatorId { get; init; }
    public required string Name { get; init; }
    public string? Description { get; init; }
    public bool IsPublic { get; init; } = true;
}

/// <summary>
/// أمر الاشتراك في قناة - Subscribe Channel Command
/// </summary>
public record SubscribeChannelCommand : IRequest<bool>
{
    public Guid ChannelId { get; init; }
    public Guid UserId { get; init; }
}

/// <summary>
/// أمر إلغاء الاشتراك من قناة - Unsubscribe Channel Command
/// </summary>
public record UnsubscribeChannelCommand : IRequest<bool>
{
    public Guid ChannelId { get; init; }
    public Guid UserId { get; init; }
}
