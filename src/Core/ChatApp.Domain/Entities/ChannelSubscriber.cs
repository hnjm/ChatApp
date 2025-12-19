using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Entities;

/// <summary>
/// مشترك القناة - Channel Subscriber Entity
/// </summary>
public class ChannelSubscriber : BaseEntity
{
    /// <summary>معرف القناة - Channel Id</summary>
    public Guid ChannelId { get; set; }
    
    /// <summary>معرف المستخدم - User Id</summary>
    public Guid UserId { get; set; }
    
    /// <summary>دور المشترك - Member Role</summary>
    public MemberRole Role { get; set; } = MemberRole.Member;
    
    /// <summary>وقت الاشتراك - Subscribed At</summary>
    public DateTime SubscribedAt { get; set; }
    
    /// <summary>هل الإشعارات مكتومة - Is Muted</summary>
    public bool IsMuted { get; set; }
    
    /// <summary>وقت انتهاء الكتم - Mute Until</summary>
    public DateTime? MuteUntil { get; set; }
    
    // Navigation Properties
    
    /// <summary>القناة - Channel</summary>
    public virtual Channel? Channel { get; set; }
    
    /// <summary>المستخدم - User</summary>
    public virtual User? User { get; set; }
    
    public ChannelSubscriber()
    {
        SubscribedAt = DateTime.UtcNow;
    }
}
