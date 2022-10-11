namespace Leet_0805
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        /// <summary>
        /// A较小的数，B较大的数
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public int Multiply(int A, int B)
        {
            if (A > B) return Multiply(B, A);
            if (A == 1)
                return B;
            if (A % 2 == 0)
            {
                return Multiply(A >> 1, B) << 1;
            }
            else
            {
                return (Multiply(A >> 1, B) << 1) + B;
            }
        }
    }
}