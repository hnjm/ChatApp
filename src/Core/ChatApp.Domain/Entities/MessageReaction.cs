namespace ChatApp.Domain.Entities;

/// <summary>
/// كيان التفاعل على الرسالة - Message Reaction Entity
/// </summary>
public class MessageReaction : BaseEntity
{
    /// <summary>معرف الرسالة - Message Id</summary>
    public Guid MessageId { get; set; }
    
    /// <summary>معرف المستخدم - User Id</summary>
    public Guid UserId { get; set; }
    
    /// <summary>نوع التفاعل (emoji) - Reaction Type</summary>
    public required string ReactionType { get; set; }
    
    // Navigation Properties
    
    /// <summary>الرسالة - Message</summary>
    public virtual Message? Message { get; set; }
    
    /// <summary>المستخدم - User</summary>
    public virtual User? User { get; set; }
}
