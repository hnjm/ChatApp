using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Entities;

/// <summary>
/// كيان المكالمة - Call Entity
/// </summary>
public class Call : BaseEntity
{
    /// <summary>معرف المحادثة - Conversation Id</summary>
    public Guid ConversationId { get; set; }
    
    /// <summary>معرف المتصل - Caller Id</summary>
    public Guid CallerId { get; set; }
    
    /// <summary>معرف المستقبل - Receiver Id</summary>
    public Guid ReceiverId { get; set; }
    
    /// <summary>نوع المكالمة - Call Type</summary>
    public CallType Type { get; set; }
    
    /// <summary>حالة المكالمة - Call Status</summary>
    public CallStatus Status { get; set; } = CallStatus.Initiating;
    
    /// <summary>وقت بداية المكالمة - Started At</summary>
    public DateTime? StartedAt { get; set; }
    
    /// <summary>وقت انتهاء المكالمة - Ended At</summary>
    public DateTime? EndedAt { get; set; }
    
    /// <summary>مدة المكالمة بالثواني - Duration in Seconds</summary>
    public int? Duration { get; set; }
    
    /// <summary>معلومات WebRTC - WebRTC Offer</summary>
    public string? WebRtcOffer { get; set; }
    
    /// <summary>معلومات WebRTC Answer - WebRTC Answer</summary>
    public string? WebRtcAnswer { get; set; }
    
    /// <summary>ICE Candidates - ICE Candidates JSON</summary>
    public string? IceCandidates { get; set; }
    
    // Navigation Properties
    
    /// <summary>المتصل - Caller</summary>
    public virtual User? Caller { get; set; }
    
    /// <summary>المستقبل - Receiver</summary>
    public virtual User? Receiver { get; set; }
}
