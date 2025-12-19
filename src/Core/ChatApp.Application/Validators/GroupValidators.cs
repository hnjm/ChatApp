using FluentValidation;
using ChatApp.Application.CQRS.Commands.Groups;

namespace ChatApp.Application.Validators;

/// <summary>
/// مدقق إنشاء مجموعة - Create Group Validator
/// </summary>
public class CreateGroupValidator : AbstractValidator<CreateGroupCommand>
{
    public CreateGroupValidator()
    {
        RuleFor(x => x.CreatorId)
            .NotEmpty().WithMessage("معرف المنشئ مطلوب - Creator ID is required");
        
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("اسم المجموعة مطلوب - Group name is required")
            .MinimumLength(3).WithMessage("اسم المجموعة قصير جداً - Group name is too short")
            .MaximumLength(100).WithMessage("اسم المجموعة طويل جداً - Group name is too long");
        
        RuleFor(x => x.Description)
            .MaximumLength(500).WithMessage("الوصف طويل جداً - Description is too long")
            .When(x => !string.IsNullOrEmpty(x.Description));
        
        RuleFor(x => x.MemberIds)
            .Must(members => members == null || members.Count <= 1000)
            .WithMessage("عدد الأعضاء كبير جداً - Too many members");
    }
}

/// <summary>
/// مدقق إضافة عضو - Add Member Validator
/// </summary>
public class AddMemberValidator : AbstractValidator<AddMemberCommand>
{
    public AddMemberValidator()
    {
        RuleFor(x => x.GroupId)
            .NotEmpty().WithMessage("معرف المجموعة مطلوب - Group ID is required");
        
        RuleFor(x => x.UserId)
            .NotEmpty().WithMessage("معرف المستخدم مطلوب - User ID is required");
        
        RuleFor(x => x.AddedBy)
            .NotEmpty().WithMessage("معرف المضيف مطلوب - Added by ID is required");
    }
}
