using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Entities;

/// <summary>
/// كيان المجموعة - Group Entity
/// </summary>
public class Group : BaseEntity
{
    /// <summary>معرف المحادثة - Conversation Id</summary>
    public Guid ConversationId { get; set; }
    
    /// <summary>اسم المجموعة - Group Name</summary>
    public required string Name { get; set; }
    
    /// <summary>وصف المجموعة - Description</summary>
    public string? Description { get; set; }
    
    /// <summary>صورة المجموعة - Image URL</summary>
    public string? ImageUrl { get; set; }
    
    /// <summary>رابط الدعوة - Invite Link</summary>
    public string? InviteLink { get; set; }
    
    /// <summary>عدد الأعضاء - Members Count</summary>
    public int MembersCount { get; set; }
    
    /// <summary>الحد الأقصى للأعضاء - Max Members</summary>
    public int MaxMembers { get; set; } = 10000;
    
    /// <summary>هل يمكن للأعضاء إرسال رسائل - Can Members Send Messages</summary>
    public bool CanMembersSendMessages { get; set; } = true;
    
    /// <summary>هل يمكن للأعضاء إضافة أعضاء جدد - Can Members Add Members</summary>
    public bool CanMembersAddMembers { get; set; } = false;
    
    /// <summary>معرف منشئ المجموعة - Creator Id</summary>
    public new Guid CreatedBy { get; set; }
    
    // Navigation Properties
    
    /// <summary>المحادثة - Conversation</summary>
    public virtual Conversation? Conversation { get; set; }
    
    /// <summary>الأعضاء - Members</summary>
    public virtual ICollection<GroupMember> Members { get; set; } = new List<GroupMember>();
}
