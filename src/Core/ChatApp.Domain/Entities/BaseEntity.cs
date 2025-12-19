namespace ChatApp.Domain.Entities;

/// <summary>
/// الصنف الأساسي لجميع الكيانات - Base Entity Class
/// </summary>
public abstract class BaseEntity
{
    /// <summary>المعرف الفريد - Unique Identifier</summary>
    public Guid Id { get; set; }
    
    /// <summary>تاريخ الإنشاء - Created Date</summary>
    public DateTime CreatedAt { get; set; }
    
    /// <summary>تاريخ آخر تحديث - Last Updated Date</summary>
    public DateTime? UpdatedAt { get; set; }
    
    /// <summary>معرف المستخدم الذي أنشأ السجل - Created By User Id</summary>
    public Guid? CreatedBy { get; set; }
    
    /// <summary>معرف المستخدم الذي حدث السجل - Updated By User Id</summary>
    public Guid? UpdatedBy { get; set; }
    
    /// <summary>هل السجل محذوف (حذف منطقي) - Is Soft Deleted</summary>
    public bool IsDeleted { get; set; }
    
    /// <summary>تاريخ الحذف - Deleted Date</summary>
    public DateTime? DeletedAt { get; set; }

    protected BaseEntity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        IsDeleted = false;
    }
}
