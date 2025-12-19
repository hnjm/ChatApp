namespace ChatApp.Application.DTOs.Channels;

/// <summary>
/// DTO للقناة - Channel DTO
/// </summary>
public record ChannelDto
{
    public Guid Id { get; init; }
    public required string Name { get; init; }
    public string? Description { get; init; }
    public string? ImageUrl { get; init; }
    public string? InviteLink { get; init; }
    public int SubscribersCount { get; init; }
    public bool IsPublic { get; init; }
    public bool IsVerified { get; init; }
    public DateTime CreatedAt { get; init; }
}

/// <summary>
/// DTO لإنشاء قناة - Create Channel DTO
/// </summary>
public record CreateChannelDto
{
    public required string Name { get; init; }
    public string? Description { get; init; }
    public bool IsPublic { get; init; } = true;
}
