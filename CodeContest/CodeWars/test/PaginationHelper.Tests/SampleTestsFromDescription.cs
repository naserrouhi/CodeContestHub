namespace PaginationHelper.Tests;

public class SampleTestsFromDescription
{
    private readonly IList<char> _collection;
    private readonly PaginationHelper<char> _helper;

    public SampleTestsFromDescription()
    {
        _collection = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' };
        _helper = new PaginationHelper<char>(_collection, 4);
    }

    [Fact]
    public void PageCountTest()
    {
        Assert.Equal(2, _helper.PageCount);
    }

    [Fact]
    public void ItemCountTest()
    {
        Assert.Equal(6, _helper.ItemCount);
    }

    [Theory]
    [InlineData(0, 4)]
    [InlineData(1, 2)]
    [InlineData(2, -1)]
    public void PageItemCountTest(int pageIndex, int expectedResult)
    {
        Assert.Equal(expectedResult, _helper.PageItemCount(pageIndex));
    }

    [Theory]
    [InlineData(5, 1)]
    [InlineData(2, 0)]
    [InlineData(20, -1)]
    [InlineData(-10, -1)]
    public void PageIndexTest(int itemIndex, int expectedResult)
    {
        Assert.Equal(expectedResult, _helper.PageIndex(itemIndex));
    }
}