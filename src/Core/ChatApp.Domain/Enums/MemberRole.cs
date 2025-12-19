namespace ChatApp.Domain.Enums;

/// <summary>
/// دور العضو في المجموعة أو القناة - Member Role
/// </summary>
public enum MemberRole
{
    /// <summary>عضو - Member</summary>
    Member = 0,
    
    /// <summary>مشرف - Moderator</summary>
    Moderator = 1,
    
    /// <summary>مسؤول - Admin</summary>
    Admin = 2,
    
    /// <summary>مالك - Owner</summary>
    Owner = 3
}
