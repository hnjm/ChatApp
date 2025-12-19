namespace ChatApp.Domain.Entities;

/// <summary>
/// كيان القناة - Channel Entity
/// </summary>
public class Channel : BaseEntity
{
    /// <summary>معرف المحادثة - Conversation Id</summary>
    public Guid ConversationId { get; set; }
    
    /// <summary>اسم القناة - Channel Name</summary>
    public required string Name { get; set; }
    
    /// <summary>وصف القناة - Description</summary>
    public string? Description { get; set; }
    
    /// <summary>صورة القناة - Image URL</summary>
    public string? ImageUrl { get; set; }
    
    /// <summary>رابط الدعوة - Invite Link</summary>
    public string? InviteLink { get; set; }
    
    /// <summary>عدد المشتركين - Subscribers Count</summary>
    public int SubscribersCount { get; set; }
    
    /// <summary>هل القناة عامة - Is Public</summary>
    public bool IsPublic { get; set; } = true;
    
    /// <summary>هل القناة مؤكدة - Is Verified</summary>
    public bool IsVerified { get; set; }
    
    /// <summary>معرف منشئ القناة - Creator Id</summary>
    public new Guid CreatedBy { get; set; }
    
    // Navigation Properties
    
    /// <summary>المحادثة - Conversation</summary>
    public virtual Conversation? Conversation { get; set; }
    
    /// <summary>المشتركون - Subscribers</summary>
    public virtual ICollection<ChannelSubscriber> Subscribers { get; set; } = new List<ChannelSubscriber>();
}
