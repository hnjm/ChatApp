using Microsoft.AspNetCore.Identity;

namespace ChatApp.Infrastructure.Identity;

/// <summary>
/// دور التطبيق - Application Role
/// </summary>
public class ApplicationRole : IdentityRole<Guid>
{
    /// <summary>الوصف - Description</summary>
    public string? Description { get; set; }
    
    /// <summary>تاريخ الإنشاء - Created Date</summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
