namespace ValidateSudoku.Tests;

public class SudokuTests
{
    [Fact]
    public void Test1()
    {
        var goodSudoku = new Sudoku(
        [
            [7,8,4, 1,5,9, 3,2,6],
            [5,3,9, 6,7,2, 8,4,1],
            [6,1,2, 4,3,8, 7,5,9],

            [9,2,8, 7,1,5, 4,6,3],
            [3,5,7, 8,4,6, 1,9,2],
            [4,6,1, 9,2,3, 5,8,7],

            [8,7,6, 3,9,4, 2,1,5],
            [2,4,3, 5,6,1, 9,7,8],
            [1,9,5, 2,8,7, 6,3,4]
        ]);

        Assert.True(goodSudoku.IsValid());
    }

    [Fact]
    public void Test2()
    {
        var goodSudoku = new Sudoku(
        [
            [1,4, 2,3],
            [3,2, 4,1],
            
            [4,1, 3,2],
            [2,3, 1,4]
        ]);

        Assert.True(goodSudoku.IsValid());
    }

    [Fact]
    public void Test3()
    {
        var badSudoku = new Sudoku(
        [
            [1,2,3, 4,5,6, 7,8,9],
            [1,2,3, 4,5,6, 7,8,9],
            [1,2,3, 4,5,6, 7,8,9],
            
            [1,2,3, 4,5,6, 7,8,9],
            [1,2,3, 4,5,6, 7,8,9],
            [1,2,3, 4,5,6, 7,8,9],
            
            [1,2,3, 4,5,6, 7,8,9],
            [1,2,3, 4,5,6, 7,8,9],
            [1,2,3, 4,5,6, 7,8,9]
        ]);

        Assert.False(badSudoku.IsValid());
    }

    [Fact]
    public void Test4()
    {
        var badSudoku = new Sudoku(
        [
            [1,2,3,4,5],
            [1,2,3,4],

            [1,2,3,4],
            [1]
        ]);

        Assert.False(badSudoku.IsValid());
    }
}