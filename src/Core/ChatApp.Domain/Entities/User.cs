using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Entities;

/// <summary>
/// كيان المستخدم - User Entity
/// </summary>
public class User : BaseEntity
{
    /// <summary>اسم المستخدم - Username</summary>
    public required string Username { get; set; }
    
    /// <summary>البريد الإلكتروني - Email</summary>
    public required string Email { get; set; }
    
    /// <summary>رقم الهاتف - Phone Number</summary>
    public string? PhoneNumber { get; set; }
    
    /// <summary>الاسم الكامل - Full Name</summary>
    public string? FullName { get; set; }
    
    /// <summary>نبذة عن المستخدم - Bio</summary>
    public string? Bio { get; set; }
    
    /// <summary>صورة الملف الشخصي - Profile Picture URL</summary>
    public string? ProfilePictureUrl { get; set; }
    
    /// <summary>حالة المستخدم - User Status</summary>
    public UserStatus Status { get; set; } = UserStatus.Offline;
    
    /// <summary>آخر ظهور - Last Seen</summary>
    public DateTime? LastSeen { get; set; }
    
    /// <summary>هل الحساب نشط - Is Active</summary>
    public bool IsActive { get; set; } = true;
    
    /// <summary>هل البريد الإلكتروني مؤكد - Is Email Confirmed</summary>
    public bool IsEmailConfirmed { get; set; }
    
    /// <summary>هل رقم الهاتف مؤكد - Is Phone Confirmed</summary>
    public bool IsPhoneConfirmed { get; set; }
    
    /// <summary>هل المصادقة الثنائية مفعلة - Is Two Factor Enabled</summary>
    public bool IsTwoFactorEnabled { get; set; }
    
    // Navigation Properties
    
    /// <summary>الرسائل المرسلة - Sent Messages</summary>
    public virtual ICollection<Message> SentMessages { get; set; } = new List<Message>();
    
    /// <summary>المحادثات - Conversations</summary>
    public virtual ICollection<ConversationUser> ConversationUsers { get; set; } = new List<ConversationUser>();
    
    /// <summary>المجموعات - Groups</summary>
    public virtual ICollection<GroupMember> GroupMembers { get; set; } = new List<GroupMember>();
    
    /// <summary>القنوات المشترك بها - Subscribed Channels</summary>
    public virtual ICollection<ChannelSubscriber> ChannelSubscribers { get; set; } = new List<ChannelSubscriber>();
    
    /// <summary>المكالمات المبدأة - Initiated Calls</summary>
    public virtual ICollection<Call> InitiatedCalls { get; set; } = new List<Call>();
    
    /// <summary>المكالمات المستقبلة - Received Calls</summary>
    public virtual ICollection<Call> ReceivedCalls { get; set; } = new List<Call>();
}
