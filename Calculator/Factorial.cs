namespace Calculator
{
    public class Factorial
    {
        public static float Eval(float number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            if (number == 0 || number == 1)
            {
                return 1;
            }

            float result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
