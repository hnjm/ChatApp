namespace ChatApp.Application.DTOs.Media;

/// <summary>
/// DTO للملف الإعلامي - Media DTO
/// </summary>
public record MediaDto
{
    public Guid Id { get; init; }
    public required string FileName { get; init; }
    public required string FileType { get; init; }
    public long FileSize { get; init; }
    public required string FileUrl { get; init; }
    public string? ThumbnailUrl { get; init; }
    public int? Width { get; init; }
    public int? Height { get; init; }
    public int? Duration { get; init; }
}

/// <summary>
/// DTO لرفع ملف إعلامي - Upload Media DTO
/// </summary>
public record UploadMediaDto
{
    public Guid MessageId { get; init; }
    public required string FileName { get; init; }
    public required string FileType { get; init; }
    public long FileSize { get; init; }
    public byte[]? FileData { get; init; }
}

/// <summary>
/// DTO للرسالة الصوتية - Voice Message DTO
/// </summary>
public record VoiceMessageDto
{
    public Guid Id { get; init; }
    public required string AudioUrl { get; init; }
    public int Duration { get; init; }
    public string? WaveformData { get; init; }
    public long FileSize { get; init; }
}
