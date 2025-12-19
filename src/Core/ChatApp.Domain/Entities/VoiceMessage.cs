namespace ChatApp.Domain.Entities;

/// <summary>
/// كيان الرسالة الصوتية - Voice Message Entity
/// </summary>
public class VoiceMessage : BaseEntity
{
    /// <summary>معرف الرسالة - Message Id</summary>
    public Guid MessageId { get; set; }
    
    /// <summary>رابط الملف الصوتي - Audio File URL</summary>
    public required string AudioUrl { get; set; }
    
    /// <summary>المدة بالثواني - Duration in Seconds</summary>
    public int Duration { get; set; }
    
    /// <summary>بيانات الموجة الصوتية - Waveform Data</summary>
    public string? WaveformData { get; set; }
    
    /// <summary>حجم الملف بالبايت - File Size in Bytes</summary>
    public long FileSize { get; set; }
    
    /// <summary>نوع الملف - File Type</summary>
    public required string FileType { get; set; }
    
    // Navigation Properties
    
    /// <summary>الرسالة - Message</summary>
    public virtual Message? Message { get; set; }
}
