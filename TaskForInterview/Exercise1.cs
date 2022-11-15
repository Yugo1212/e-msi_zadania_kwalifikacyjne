namespace TaskForInterview
{
    public class Exercise1
    {
        // Napisz testy jednostkowe dla poniższych metod:

        public string CheckSix(int num)
        {
            const int six = 6;
            string? result;
            if (num < six)
                result = $"{num} is less than {six}.";
            else if (num == six)
                result = $"{num} is equal to {six}.";
            else
                result = $"{num} is more than {six}.";

            return result;
        }

        public double CalculateY(double x)
        {
            if (x < -1.5)
                return 0;
            return Math.Pow(x, 2);
        }
    }
}