namespace UN.EntityFramework.Extensions.Pagination
{
    public class PageQuery : IPageQuery
    {
        public int PageSize { get ; set ; }
        public int PageNr { get ; set ; }
    }
}
