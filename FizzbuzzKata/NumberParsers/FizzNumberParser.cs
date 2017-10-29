namespace FizzbuzzKata
{
    public class FizzNumberParser : INumberParser
    {
        public int Divisor => 3;

        public string Parse(int number)
        {
            if(number % Divisor == 0)
                return "Fizz";

            return number.ToString();
        }
    }
}
