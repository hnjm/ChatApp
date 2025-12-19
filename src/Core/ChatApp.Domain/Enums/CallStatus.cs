namespace ChatApp.Domain.Enums;

/// <summary>
/// حالة المكالمة - Call Status
/// </summary>
public enum CallStatus
{
    /// <summary>قيد الاتصال - Initiating</summary>
    Initiating = 0,
    
    /// <summary>رنين - Ringing</summary>
    Ringing = 1,
    
    /// <summary>متصل - Connected</summary>
    Connected = 2,
    
    /// <summary>انتهت - Ended</summary>
    Ended = 3,
    
    /// <summary>مرفوضة - Rejected</summary>
    Rejected = 4,
    
    /// <summary>لا رد - Missed</summary>
    Missed = 5,
    
    /// <summary>مشغول - Busy</summary>
    Busy = 6
}
