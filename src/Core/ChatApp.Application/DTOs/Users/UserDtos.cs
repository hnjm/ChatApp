namespace ChatApp.Application.DTOs.Users;

/// <summary>
/// DTO للمستخدم - User DTO
/// </summary>
public record UserDto
{
    public Guid Id { get; init; }
    public required string Username { get; init; }
    public required string Email { get; init; }
    public string? PhoneNumber { get; init; }
    public string? FullName { get; init; }
    public string? Bio { get; init; }
    public string? ProfilePictureUrl { get; init; }
    public string Status { get; init; } = "Offline";
    public DateTime? LastSeen { get; init; }
    public bool IsActive { get; init; }
}

/// <summary>
/// DTO لإنشاء مستخدم - Create User DTO
/// </summary>
public record CreateUserDto
{
    public required string Username { get; init; }
    public required string Email { get; init; }
    public required string Password { get; init; }
    public string? PhoneNumber { get; init; }
    public string? FullName { get; init; }
}

/// <summary>
/// DTO لتحديث المستخدم - Update User DTO
/// </summary>
public record UpdateUserDto
{
    public string? FullName { get; init; }
    public string? Bio { get; init; }
    public string? PhoneNumber { get; init; }
}

/// <summary>
/// DTO لملف المستخدم الشخصي - User Profile DTO
/// </summary>
public record UserProfileDto
{
    public Guid Id { get; init; }
    public required string Username { get; init; }
    public string? FullName { get; init; }
    public string? Bio { get; init; }
    public string? ProfilePictureUrl { get; init; }
    public string Status { get; init; } = "Offline";
    public DateTime? LastSeen { get; init; }
    public int TotalConversations { get; init; }
    public int TotalGroups { get; init; }
    public int TotalChannels { get; init; }
}
