namespace task2
{



    public class Logic
    {
        public static string FindMaxValue(int n)
        {
            int max = n;
            string answer = "";
            for (int i = 1; i < max; i++)
            {
                if (i * i > max)
                {
                    answer = max.ToString();
                    break;
                }
                answer = (i * i) + " ";
            }

            return answer;
        }


        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите число");
                var n = int.Parse(Console.ReadLine());

                Console.WriteLine(Logic.FindMaxValue(n));


            }
        }
    }
}