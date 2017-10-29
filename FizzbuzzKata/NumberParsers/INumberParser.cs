namespace FizzbuzzKata
{
    public interface INumberParser
    {
        int Divisor { get; }
        string Parse(int number);
    }
}