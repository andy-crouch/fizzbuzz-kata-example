namespace FizzbuzzKata
{
    public class FizzbuzzNumberParser : INumberParser
    {
        public int Divisor => 15;

        public string Parse(int number)
        {
            if (number % Divisor == 0)
                return "Fizzbuzz";

            return number.ToString();
        }
    }
}
