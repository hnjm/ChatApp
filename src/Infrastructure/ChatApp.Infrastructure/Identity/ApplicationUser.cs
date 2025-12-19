using Microsoft.AspNetCore.Identity;

namespace ChatApp.Infrastructure.Identity;

/// <summary>
/// مستخدم التطبيق - Application User
/// Extends IdentityUser with additional properties
/// </summary>
public class ApplicationUser : IdentityUser<Guid>
{
    /// <summary>الاسم الكامل - Full Name</summary>
    public string? FullName { get; set; }
    
    /// <summary>نبذة عن المستخدم - Bio</summary>
    public string? Bio { get; set; }
    
    /// <summary>صورة الملف الشخصي - Profile Picture URL</summary>
    public string? ProfilePictureUrl { get; set; }
    
    /// <summary>تاريخ الإنشاء - Created Date</summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    /// <summary>آخر ظهور - Last Seen</summary>
    public DateTime? LastSeen { get; set; }
    
    /// <summary>هل الحساب نشط - Is Active</summary>
    public bool IsActive { get; set; } = true;
    
    /// <summary>معرف المستخدم في جدول Users - User Entity Id</summary>
    public Guid? UserEntityId { get; set; }
}
