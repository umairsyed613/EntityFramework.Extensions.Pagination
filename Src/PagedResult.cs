using System.Collections.Generic;

namespace UN.EntityFramework.Extensions.Pagination
{
    public class PagedResult<T>
    {
        public int PageSize { get; set; }

        public int PageNr { get; set; }

        public int TotalItems { get; set; }

        public ICollection<T> PageResults { get; set; }
    }
}
