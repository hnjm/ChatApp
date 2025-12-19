namespace ChatApp.Domain.Enums;

/// <summary>
/// حالة المستخدم - User Status
/// </summary>
public enum UserStatus
{
    /// <summary>متصل - Online</summary>
    Online = 0,
    
    /// <summary>غير متصل - Offline</summary>
    Offline = 1,
    
    /// <summary>بعيد - Away</summary>
    Away = 2,
    
    /// <summary>مشغول - Busy</summary>
    Busy = 3
}
