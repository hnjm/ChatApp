using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Entities;

/// <summary>
/// عضو المجموعة - Group Member Entity
/// </summary>
public class GroupMember : BaseEntity
{
    /// <summary>معرف المجموعة - Group Id</summary>
    public Guid GroupId { get; set; }
    
    /// <summary>معرف المستخدم - User Id</summary>
    public Guid UserId { get; set; }
    
    /// <summary>دور العضو - Member Role</summary>
    public MemberRole Role { get; set; } = MemberRole.Member;
    
    /// <summary>وقت الانضمام - Joined At</summary>
    public DateTime JoinedAt { get; set; }
    
    /// <summary>من أضاف العضو - Added By User Id</summary>
    public Guid? AddedBy { get; set; }
    
    /// <summary>هل العضو مكتوم - Is Muted</summary>
    public bool IsMuted { get; set; }
    
    /// <summary>وقت انتهاء الكتم - Mute Until</summary>
    public DateTime? MuteUntil { get; set; }
    
    // Navigation Properties
    
    /// <summary>المجموعة - Group</summary>
    public virtual Group? Group { get; set; }
    
    /// <summary>المستخدم - User</summary>
    public virtual User? User { get; set; }
    
    public GroupMember()
    {
        JoinedAt = DateTime.UtcNow;
    }
}
