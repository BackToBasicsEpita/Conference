namespace DebugMe;

public class Powers
{
    /* <summary>
     * Calculates the sum of the powers of 3 from 3^0 to 3^n (included)
     * </summary>
     *
     * <param name="n">the number of terms in the sum</param>
     * <returns>the calculated sum, or -1 if n < 0</returns>
     */
    public static long PowerSum(int n)
    {
        if (n < 0)
            return -1;

        long result = 1;
        int power = 3;
        for (int i = 1; i <= n; i++)
        {
            result += power;
            power *= 3;
        }

        return result;
    }
    
    /* <summary>
     * Calculates the result of x^n using fast exponentiation
     * </summary>
     *
     * <param name="x">the number raised to the given power <paramref>n</paramref></param>
     * <param name="n">the number of terms in the multiplication</param>
     * <returns>the result of the power</returns>
     */
    public static int Power(int x, int n)
    {
        if (n == 0)
        {
            return 1;
        }

        if (n % 2 == 0)
        {
            return Power(x * x, n / 2);
        }

        return Power(x * x, n / 2);
    }
}
