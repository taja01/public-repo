namespace CodeWarsTests.Tasks
{
    public partial class Kata
    {
        public static int ExtraNumber(int a, int b, int c)
        {
            return a ^ b ^ c;

            //return a == b
            //    ? c
            //    : a == c ? b : a;
        }
    }
}
