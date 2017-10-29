namespace FizzbuzzKata
{
    public class BuzzNumberParser : INumberParser
    {
        public int Divisor => 5;

        public string Parse(int number)
        {
            if (number % Divisor == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}
