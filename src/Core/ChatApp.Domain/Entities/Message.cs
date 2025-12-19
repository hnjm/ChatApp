using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Entities;

/// <summary>
/// كيان الرسالة - Message Entity
/// </summary>
public class Message : BaseEntity
{
    /// <summary>معرف المحادثة - Conversation Id</summary>
    public Guid ConversationId { get; set; }
    
    /// <summary>معرف المرسل - Sender Id</summary>
    public Guid SenderId { get; set; }
    
    /// <summary>نوع الرسالة - Message Type</summary>
    public MessageType Type { get; set; }
    
    /// <summary>محتوى الرسالة النصي - Text Content</summary>
    public string? Content { get; set; }
    
    /// <summary>معرف الرسالة المرد عليها - Reply To Message Id</summary>
    public Guid? ReplyToMessageId { get; set; }
    
    /// <summary>معرف الرسالة المعاد توجيهها - Forwarded From Message Id</summary>
    public Guid? ForwardedFromMessageId { get; set; }
    
    /// <summary>هل الرسالة محررة - Is Edited</summary>
    public bool IsEdited { get; set; }
    
    /// <summary>وقت التعديل - Edited At</summary>
    public DateTime? EditedAt { get; set; }
    
    /// <summary>هل الرسالة محذوفة للجميع - Is Deleted For Everyone</summary>
    public bool IsDeletedForEveryone { get; set; }
    
    /// <summary>وقت الحذف للجميع - Deleted For Everyone At</summary>
    public DateTime? DeletedForEveryoneAt { get; set; }
    
    /// <summary>هل الرسالة مثبتة - Is Pinned</summary>
    public bool IsPinned { get; set; }
    
    /// <summary>عدد التفاعلات - Reactions Count</summary>
    public int ReactionsCount { get; set; }
    
    /// <summary>معرف الملف الإعلامي (إن وجد) - Media Id</summary>
    public Guid? MediaId { get; set; }
    
    /// <summary>معرف الرسالة الصوتية (إن وجدت) - Voice Message Id</summary>
    public Guid? VoiceMessageId { get; set; }
    
    // Navigation Properties
    
    /// <summary>المحادثة - Conversation</summary>
    public virtual Conversation? Conversation { get; set; }
    
    /// <summary>المرسل - Sender</summary>
    public virtual User? Sender { get; set; }
    
    /// <summary>الرسالة المرد عليها - Reply To Message</summary>
    public virtual Message? ReplyToMessage { get; set; }
    
    /// <summary>الرسالة المعاد توجيهها - Forwarded From Message</summary>
    public virtual Message? ForwardedFromMessage { get; set; }
    
    /// <summary>الرسائل التي ردت على هذه الرسالة - Replies</summary>
    public virtual ICollection<Message> Replies { get; set; } = new List<Message>();
    
    /// <summary>الرسائل المعاد توجيهها من هذه الرسالة - Forwarded Messages</summary>
    public virtual ICollection<Message> ForwardedMessages { get; set; } = new List<Message>();
    
    /// <summary>الملف الإعلامي - Media</summary>
    public virtual Media? Media { get; set; }
    
    /// <summary>الرسالة الصوتية - Voice Message</summary>
    public virtual VoiceMessage? VoiceMessage { get; set; }
    
    /// <summary>التفاعلات - Reactions</summary>
    public virtual ICollection<MessageReaction> Reactions { get; set; } = new List<MessageReaction>();
    
    /// <summary>حالات القراءة - Read Status</summary>
    public virtual ICollection<MessageReadStatus> ReadStatuses { get; set; } = new List<MessageReadStatus>();
}
