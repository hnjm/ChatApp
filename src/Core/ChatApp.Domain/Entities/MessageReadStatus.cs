namespace ChatApp.Domain.Entities;

/// <summary>
/// حالة قراءة الرسالة - Message Read Status Entity
/// </summary>
public class MessageReadStatus : BaseEntity
{
    /// <summary>معرف الرسالة - Message Id</summary>
    public Guid MessageId { get; set; }
    
    /// <summary>معرف المستخدم - User Id</summary>
    public Guid UserId { get; set; }
    
    /// <summary>وقت القراءة - Read At</summary>
    public DateTime ReadAt { get; set; }
    
    /// <summary>هل تم التسليم - Is Delivered</summary>
    public bool IsDelivered { get; set; }
    
    /// <summary>وقت التسليم - Delivered At</summary>
    public DateTime? DeliveredAt { get; set; }
    
    // Navigation Properties
    
    /// <summary>الرسالة - Message</summary>
    public virtual Message? Message { get; set; }
    
    /// <summary>المستخدم - User</summary>
    public virtual User? User { get; set; }
    
    public MessageReadStatus()
    {
        ReadAt = DateTime.UtcNow;
    }
}
