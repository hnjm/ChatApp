namespace ChatApp.Domain.Enums;

/// <summary>
/// نوع الرسالة - Message Type
/// </summary>
public enum MessageType
{
    /// <summary>نص - Text</summary>
    Text = 0,
    
    /// <summary>صورة - Image</summary>
    Image = 1,
    
    /// <summary>فيديو - Video</summary>
    Video = 2,
    
    /// <summary>صوت - Audio</summary>
    Audio = 3,
    
    /// <summary>ملف - File</summary>
    File = 4,
    
    /// <summary>رسالة صوتية - Voice Message</summary>
    Voice = 5,
    
    /// <summary>مستند - Document</summary>
    Document = 6
}
