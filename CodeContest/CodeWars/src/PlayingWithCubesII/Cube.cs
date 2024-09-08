namespace PlayingWithCubesII;

public class Cube
{
    private int _side;

    public Cube() => _side = 0;

    public Cube(int side) => _side = Math.Abs(side);

    public int GetSide() => _side;

    public void SetSide(int side) => _side = Math.Abs(side);
}