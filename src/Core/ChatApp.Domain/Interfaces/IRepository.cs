using System.Linq.Expressions;

namespace ChatApp.Domain.Interfaces;

/// <summary>
/// واجهة المستودع العام - Generic Repository Interface
/// </summary>
/// <typeparam name="T">نوع الكيان - Entity Type</typeparam>
public interface IRepository<T> where T : class
{
    /// <summary>الحصول على كيان بواسطة المعرف - Get Entity By Id</summary>
    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    
    /// <summary>الحصول على جميع الكيانات - Get All Entities</summary>
    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
    
    /// <summary>البحث عن كيانات بشرط - Find Entities By Condition</summary>
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);
    
    /// <summary>الحصول على كيان واحد بشرط - Get Single Entity By Condition</summary>
    Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);
    
    /// <summary>إضافة كيان جديد - Add New Entity</summary>
    Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
    
    /// <summary>إضافة عدة كيانات - Add Multiple Entities</summary>
    Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);
    
    /// <summary>تحديث كيان - Update Entity</summary>
    void Update(T entity);
    
    /// <summary>حذف كيان - Delete Entity</summary>
    void Delete(T entity);
    
    /// <summary>حذف عدة كيانات - Delete Multiple Entities</summary>
    void DeleteRange(IEnumerable<T> entities);
    
    /// <summary>عدد الكيانات - Count Entities</summary>
    Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null, CancellationToken cancellationToken = default);
    
    /// <summary>التحقق من وجود كيان - Check If Entity Exists</summary>
    Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);
}
