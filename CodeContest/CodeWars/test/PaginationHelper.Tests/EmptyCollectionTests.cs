namespace PaginationHelper.Tests;

public class EmptyCollectionTests
{
    private readonly IList<string> _collection;
    private readonly PaginationHelper<string> _helper;

    public EmptyCollectionTests()
    {
        _collection = [];
        _helper = new PaginationHelper<string>(_collection, 4);
    }

    [Fact]
    public void PageCountTest()
    {
        Assert.Equal(0, _helper.PageCount);
    }

    [Fact]
    public void ItemCountTest()
    {
        Assert.Equal(0, _helper.ItemCount);
    }


    [Theory]
    [InlineData(0, -1)]
    [InlineData(1, -1)]
    [InlineData(-1, -1)]
    public void PageItemCountTest(int pageIndex, int expectedResult)
    {
        Assert.Equal(expectedResult, _helper.PageItemCount(pageIndex));
    }

    [Theory]
    [InlineData(0, -1)]
    [InlineData(1, -1)]
    [InlineData(-1, -1)]
    public void PageIndexTest(int itemIndex, int expectedResult)
    {
        Assert.Equal(expectedResult, _helper.PageIndex(itemIndex));
    }
}