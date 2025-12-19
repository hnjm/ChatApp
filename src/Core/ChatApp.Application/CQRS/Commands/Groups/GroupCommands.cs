using MediatR;
using ChatApp.Application.DTOs.Groups;

namespace ChatApp.Application.CQRS.Commands.Groups;

/// <summary>
/// أمر إنشاء مجموعة - Create Group Command
/// </summary>
public record CreateGroupCommand : IRequest<GroupDto>
{
    public Guid CreatorId { get; init; }
    public required string Name { get; init; }
    public string? Description { get; init; }
    public List<Guid> MemberIds { get; init; } = new();
}

/// <summary>
/// أمر إضافة عضو للمجموعة - Add Member Command
/// </summary>
public record AddMemberCommand : IRequest<bool>
{
    public Guid GroupId { get; init; }
    public Guid UserId { get; init; }
    public Guid AddedBy { get; init; }
}

/// <summary>
/// أمر إزالة عضو من المجموعة - Remove Member Command
/// </summary>
public record RemoveMemberCommand : IRequest<bool>
{
    public Guid GroupId { get; init; }
    public Guid UserId { get; init; }
    public Guid RemovedBy { get; init; }
}

/// <summary>
/// أمر تحديث دور العضو - Update Member Role Command
/// </summary>
public record UpdateMemberRoleCommand : IRequest<bool>
{
    public Guid GroupId { get; init; }
    public Guid UserId { get; init; }
    public Guid UpdatedBy { get; init; }
    public required string NewRole { get; init; }
}
