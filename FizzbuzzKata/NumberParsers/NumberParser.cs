namespace FizzbuzzKata
{
    public class NumberParser : INumberParser
    {
        public int Divisor => -1;

        public string Parse(int number)
        {
            return number.ToString();
        }
    }
}
