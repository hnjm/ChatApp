namespace ChatApp.Domain.Entities;

/// <summary>
/// علاقة المستخدم بالمحادثة - Conversation User Join Table
/// </summary>
public class ConversationUser : BaseEntity
{
    /// <summary>معرف المحادثة - Conversation Id</summary>
    public Guid ConversationId { get; set; }
    
    /// <summary>معرف المستخدم - User Id</summary>
    public Guid UserId { get; set; }
    
    /// <summary>آخر رسالة مقروءة - Last Read Message Id</summary>
    public Guid? LastReadMessageId { get; set; }
    
    /// <summary>عدد الرسائل غير المقروءة - Unread Count</summary>
    public int UnreadCount { get; set; }
    
    /// <summary>هل الإشعارات مكتومة - Is Muted</summary>
    public bool IsMuted { get; set; }
    
    /// <summary>وقت انضمام المستخدم - Joined At</summary>
    public DateTime JoinedAt { get; set; }
    
    /// <summary>وقت مغادرة المستخدم - Left At</summary>
    public DateTime? LeftAt { get; set; }
    
    // Navigation Properties
    
    /// <summary>المحادثة - Conversation</summary>
    public virtual Conversation? Conversation { get; set; }
    
    /// <summary>المستخدم - User</summary>
    public virtual User? User { get; set; }
    
    public ConversationUser()
    {
        JoinedAt = DateTime.UtcNow;
    }
}
