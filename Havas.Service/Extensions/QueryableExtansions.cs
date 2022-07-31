using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Service.Extensions
{
    public static class QueryableExtansions
    {
        public static IEnumerable<T> GetWithPagination<T>(this IQueryable<T> value, Tuple<int, int>? pagination = null)
        {
            if(pagination is null)
                return value.AsEnumerable();
            
            return value.Skip((pagination.Item1 - 1) * pagination.Item2).Take(pagination.Item2);
        }
    }
}
