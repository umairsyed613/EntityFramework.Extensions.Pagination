namespace EntityFramework.Pagination
{
    public interface IPageQuery
    {
        int PageSize { get; set; }

        int PageNr { get; set; }
    }
}
