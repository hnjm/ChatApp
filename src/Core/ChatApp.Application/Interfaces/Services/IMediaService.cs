using ChatApp.Application.DTOs.Media;

namespace ChatApp.Application.Interfaces.Services;

/// <summary>
/// واجهة خدمة الملفات الإعلامية - Media Service Interface
/// </summary>
public interface IMediaService
{
    Task<MediaDto> UploadMediaAsync(Guid messageId, string fileName, string fileType, Stream fileStream, CancellationToken cancellationToken = default);
    Task<Stream> DownloadMediaAsync(Guid mediaId, CancellationToken cancellationToken = default);
    Task<bool> DeleteMediaAsync(Guid mediaId, CancellationToken cancellationToken = default);
    Task<string> GenerateThumbnailAsync(Guid mediaId, CancellationToken cancellationToken = default);
}
