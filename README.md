# UN.EntityFramework.Extensions.Pagination
EntityFramework query extension for getting page data from database for views

### Getting started

Install the [UN.EntityFramework.Extensions.Pagination](https://www.nuget.org/packages/UN.EntityFramework.Extensions.Pagination/) package from NuGet:

```powershell
Install-Package UN.EntityFramework.Extensions.Pagination
```


### How it works

Example 1
```charp
public asyc Task<PagedResult<YourModel>> GetMyModelsByPage(IPageQuery pageQuery)
{
	var result = await dbcontext.Table
                .TakePageResult(pageQuery).ToArrayAsync();

	var totalItems = result.Count;
	
    return new PagedResult<YourModel>
    {
        TotalItems = totalItems,
        PageSize = pageQuery.PageSize,
        Page = pageQuery.PageNr,
        Result = result
    };
}
```

Example 2
Get all the list of persons based on name from your database

```csharp
public class MySearchQuery : IPageQuery
{
	public string Name { get ; set ; }	
	public int PageSize { get ; set ; }
	public int PageNr { get ; set ; }
}

public asyc Task<PagedResult<Person>> GetPersonsByNameAndPageResult(MySearchQuery searchQuery)
{
	var result = await dbcontext.Persons.Where(w => x.Name == searchQuery.Name)
                .TakePageResult(searchQuery).ToArrayAsync();

	var totalItems = result.Count;
	
    return new PagedResult<Person>
    {
        TotalItems = totalItems,
        PageSize = searchQuery.PageSize,
        Page = searchQuery.PageNr,
        Result = result
    };
}

```
