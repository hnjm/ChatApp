using MediatR;
using ChatApp.Application.DTOs.Users;

namespace ChatApp.Application.CQRS.Queries.Users;

/// <summary>
/// استعلام للحصول على المستخدمين - Get Users Query
/// </summary>
public record GetUsersQuery : IRequest<List<UserDto>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 20;
}

/// <summary>
/// استعلام البحث عن المستخدمين - Search Users Query
/// </summary>
public record SearchUsersQuery : IRequest<List<UserDto>>
{
    public required string SearchTerm { get; init; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 20;
}

/// <summary>
/// استعلام للحصول على ملف المستخدم - Get User Profile Query
/// </summary>
public record GetUserProfileQuery : IRequest<UserProfileDto?>
{
    public Guid UserId { get; init; }
}
