using FluentValidation;
using ChatApp.Application.CQRS.Commands.Messages;

namespace ChatApp.Application.Validators;

/// <summary>
/// مدقق إرسال رسالة نصية - Send Text Message Validator
/// </summary>
public class SendTextMessageValidator : AbstractValidator<SendTextMessageCommand>
{
    public SendTextMessageValidator()
    {
        RuleFor(x => x.SenderId)
            .NotEmpty().WithMessage("معرف المرسل مطلوب - Sender ID is required");
        
        RuleFor(x => x.ConversationId)
            .NotEmpty().WithMessage("معرف المحادثة مطلوب - Conversation ID is required");
        
        RuleFor(x => x.Content)
            .NotEmpty().WithMessage("محتوى الرسالة مطلوب - Message content is required")
            .MaximumLength(10000).WithMessage("محتوى الرسالة طويل جداً - Message content is too long");
    }
}

/// <summary>
/// مدقق إرسال رسالة إعلامية - Send Media Message Validator
/// </summary>
public class SendMediaMessageValidator : AbstractValidator<SendMediaMessageCommand>
{
    public SendMediaMessageValidator()
    {
        RuleFor(x => x.SenderId)
            .NotEmpty().WithMessage("معرف المرسل مطلوب - Sender ID is required");
        
        RuleFor(x => x.ConversationId)
            .NotEmpty().WithMessage("معرف المحادثة مطلوب - Conversation ID is required");
        
        RuleFor(x => x.MediaType)
            .NotEmpty().WithMessage("نوع الملف مطلوب - Media type is required")
            .Must(type => new[] { "Image", "Video", "Audio", "File", "Document" }.Contains(type))
            .WithMessage("نوع الملف غير صحيح - Invalid media type");
        
        RuleFor(x => x.FileUrl)
            .NotEmpty().WithMessage("رابط الملف مطلوب - File URL is required");
    }
}

/// <summary>
/// مدقق تعديل رسالة - Edit Message Validator
/// </summary>
public class EditMessageValidator : AbstractValidator<EditMessageCommand>
{
    public EditMessageValidator()
    {
        RuleFor(x => x.MessageId)
            .NotEmpty().WithMessage("معرف الرسالة مطلوب - Message ID is required");
        
        RuleFor(x => x.UserId)
            .NotEmpty().WithMessage("معرف المستخدم مطلوب - User ID is required");
        
        RuleFor(x => x.NewContent)
            .NotEmpty().WithMessage("المحتوى الجديد مطلوب - New content is required")
            .MaximumLength(10000).WithMessage("المحتوى طويل جداً - Content is too long");
    }
}
