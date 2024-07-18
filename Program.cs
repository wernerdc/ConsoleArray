namespace ConsoleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();

            Console.WriteLine("ConsoleArray \n");

            int[] randomNums = GetRandomNumsArray(20);

            for (int i = 0; i < randomNums.Length; i++)
            {
                if (randomNums[i] % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;

                }
                Console.Write(randomNums[i] + " ");           
            }


            Console.ReadLine();

        }

        static private int[] GetRandomNumsArray(int size)
        {
            Random r = new Random();
            int[] randomNums = new int[size];

            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = r.Next(1, 7);
            }

            return randomNums;
        }
    }
}
