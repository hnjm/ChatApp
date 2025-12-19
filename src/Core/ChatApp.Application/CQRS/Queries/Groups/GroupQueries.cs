using MediatR;
using ChatApp.Application.DTOs.Groups;

namespace ChatApp.Application.CQRS.Queries.Groups;

/// <summary>
/// استعلام للحصول على المجموعات - Get Groups Query
/// </summary>
public record GetGroupsQuery : IRequest<List<GroupDto>>
{
    public Guid UserId { get; init; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 20;
}

/// <summary>
/// استعلام للحصول على مجموعة معينة - Get Group By Id Query
/// </summary>
public record GetGroupByIdQuery : IRequest<GroupDto?>
{
    public Guid GroupId { get; init; }
}

/// <summary>
/// استعلام للحصول على أعضاء المجموعة - Get Group Members Query
/// </summary>
public record GetGroupMembersQuery : IRequest<List<GroupMemberDto>>
{
    public Guid GroupId { get; init; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 100;
}
