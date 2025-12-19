namespace ChatApp.Application.DTOs.Groups;

/// <summary>
/// DTO للمجموعة - Group DTO
/// </summary>
public record GroupDto
{
    public Guid Id { get; init; }
    public required string Name { get; init; }
    public string? Description { get; init; }
    public string? ImageUrl { get; init; }
    public string? InviteLink { get; init; }
    public int MembersCount { get; init; }
    public int MaxMembers { get; init; }
    public bool CanMembersSendMessages { get; init; }
    public bool CanMembersAddMembers { get; init; }
    public DateTime CreatedAt { get; init; }
}

/// <summary>
/// DTO لإنشاء مجموعة - Create Group DTO
/// </summary>
public record CreateGroupDto
{
    public required string Name { get; init; }
    public string? Description { get; init; }
    public List<Guid> MemberIds { get; init; } = new();
}

/// <summary>
/// DTO لعضو المجموعة - Group Member DTO
/// </summary>
public record GroupMemberDto
{
    public Guid UserId { get; init; }
    public required string Username { get; init; }
    public string? FullName { get; init; }
    public string? ProfilePictureUrl { get; init; }
    public string Role { get; init; } = "Member";
    public DateTime JoinedAt { get; init; }
}
