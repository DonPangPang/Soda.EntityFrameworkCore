using Microsoft.EntityFrameworkCore;

namespace Soda.EntityFrameworkCore.Extensions;

public static class TableExtensions
{
    /// <summary>
    /// 确保表已经被创建
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    /// <param name="dbContext"> </param>
    /// <param name="types">     </param>
    /// <exception cref="ArgumentNullException"> </exception>
    public static void EnsureCreateTable<T>(this T dbContext, params Type[] types) where T : DbContext
    {
        if (dbContext == null) throw new ArgumentNullException(nameof(dbContext));
        if (types == null) throw new ArgumentNullException(nameof(types));
    }
}