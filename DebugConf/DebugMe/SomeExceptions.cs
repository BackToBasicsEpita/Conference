namespace DebugMe;

public class StringAnalyzer
{
    /* <summary>
     * Check if <paramref>c</paramref> is a lowercase character
     * </summary>
     *
     * <param name="c">the character to analyse</param>
     * <returns>true if <paramref>c</paramref> is lowercase, false otherwise</returns>
     */
    private static bool IsLowerChar(char c)
    {
        return c >= 'a' && c <= 'z';
    }

    /* <summary>
     * Check if a string only contains lowercase characters
     * </summary>
     *
     * <param name="str">the string to analyse</param>
     * <returns>true if the string is only composed of lowercase characters, false otherwise</returns>
     */
    public static bool IsLowerCase(string str)
    {
        int i = 0;
        int n = str.Length;
        while (i <= n && IsLowerChar(str[i]))
        {
            i++;
        }

        return i == n;
    }
}
