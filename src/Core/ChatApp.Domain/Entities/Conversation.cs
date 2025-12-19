using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Entities;

/// <summary>
/// كيان المحادثة - Conversation Entity
/// </summary>
public class Conversation : BaseEntity
{
    /// <summary>نوع المحادثة - Conversation Type</summary>
    public ConversationType Type { get; set; }
    
    /// <summary>عنوان المحادثة (للمجموعات والقنوات) - Title</summary>
    public string? Title { get; set; }
    
    /// <summary>وصف المحادثة - Description</summary>
    public string? Description { get; set; }
    
    /// <summary>صورة المحادثة - Image URL</summary>
    public string? ImageUrl { get; set; }
    
    /// <summary>آخر رسالة - Last Message</summary>
    public string? LastMessage { get; set; }
    
    /// <summary>وقت آخر رسالة - Last Message Time</summary>
    public DateTime? LastMessageAt { get; set; }
    
    /// <summary>هل المحادثة مؤرشفة - Is Archived</summary>
    public bool IsArchived { get; set; }
    
    /// <summary>هل المحادثة مثبتة - Is Pinned</summary>
    public bool IsPinned { get; set; }
    
    /// <summary>معرف المجموعة (إذا كانت مجموعة) - Group Id</summary>
    public Guid? GroupId { get; set; }
    
    /// <summary>معرف القناة (إذا كانت قناة) - Channel Id</summary>
    public Guid? ChannelId { get; set; }
    
    // Navigation Properties
    
    /// <summary>الرسائل - Messages</summary>
    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
    
    /// <summary>المستخدمون في المحادثة - Users</summary>
    public virtual ICollection<ConversationUser> ConversationUsers { get; set; } = new List<ConversationUser>();
    
    /// <summary>المجموعة - Group</summary>
    public virtual Group? Group { get; set; }
    
    /// <summary>القناة - Channel</summary>
    public virtual Channel? Channel { get; set; }
}
