namespace ChatApp.Domain.Interfaces;

/// <summary>
/// واجهة وحدة العمل - Unit of Work Interface
/// </summary>
public interface IUnitOfWork : IDisposable
{
    /// <summary>حفظ التغييرات - Save Changes</summary>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    
    /// <summary>بدء معاملة - Begin Transaction</summary>
    Task BeginTransactionAsync(CancellationToken cancellationToken = default);
    
    /// <summary>تأكيد المعاملة - Commit Transaction</summary>
    Task CommitTransactionAsync(CancellationToken cancellationToken = default);
    
    /// <summary>إلغاء المعاملة - Rollback Transaction</summary>
    Task RollbackTransactionAsync(CancellationToken cancellationToken = default);
}
