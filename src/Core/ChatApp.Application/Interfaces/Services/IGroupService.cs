using ChatApp.Application.DTOs.Groups;

namespace ChatApp.Application.Interfaces.Services;

/// <summary>
/// واجهة خدمة المجموعات - Group Service Interface
/// </summary>
public interface IGroupService
{
    Task<GroupDto?> GetGroupByIdAsync(Guid groupId, CancellationToken cancellationToken = default);
    Task<List<GroupDto>> GetUserGroupsAsync(Guid userId, int pageNumber, int pageSize, CancellationToken cancellationToken = default);
    Task<GroupDto> CreateGroupAsync(Guid creatorId, string name, string? description, List<Guid> memberIds, CancellationToken cancellationToken = default);
    Task<bool> AddMemberAsync(Guid groupId, Guid userId, Guid addedBy, CancellationToken cancellationToken = default);
    Task<bool> RemoveMemberAsync(Guid groupId, Guid userId, Guid removedBy, CancellationToken cancellationToken = default);
    Task<List<GroupMemberDto>> GetGroupMembersAsync(Guid groupId, int pageNumber, int pageSize, CancellationToken cancellationToken = default);
    Task<bool> UpdateMemberRoleAsync(Guid groupId, Guid userId, string newRole, Guid updatedBy, CancellationToken cancellationToken = default);
}
