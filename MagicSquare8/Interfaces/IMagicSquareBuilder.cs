namespace MagicSquare8.Interfaces
{
    public interface IMagicSquareBuilder
    {
        int?[,] Build(IList<int> elements);
    }
}