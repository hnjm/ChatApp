namespace ChatApp.Domain.Entities;

/// <summary>
/// كيان الملف الإعلامي - Media Entity
/// </summary>
public class Media : BaseEntity
{
    /// <summary>اسم الملف - File Name</summary>
    public required string FileName { get; set; }
    
    /// <summary>نوع الملف - File Type</summary>
    public required string FileType { get; set; }
    
    /// <summary>حجم الملف بالبايت - File Size in Bytes</summary>
    public long FileSize { get; set; }
    
    /// <summary>رابط الملف - File URL</summary>
    public required string FileUrl { get; set; }
    
    /// <summary>رابط الصورة المصغرة - Thumbnail URL</summary>
    public string? ThumbnailUrl { get; set; }
    
    /// <summary>العرض (للصور والفيديو) - Width</summary>
    public int? Width { get; set; }
    
    /// <summary>الارتفاع (للصور والفيديو) - Height</summary>
    public int? Height { get; set; }
    
    /// <summary>المدة بالثواني (للفيديو والصوت) - Duration in Seconds</summary>
    public int? Duration { get; set; }
    
    /// <summary>معرف الرسالة - Message Id</summary>
    public Guid MessageId { get; set; }
    
    // Navigation Properties
    
    /// <summary>الرسالة - Message</summary>
    public virtual Message? Message { get; set; }
}
