namespace task2
{



    public class Logic
    {
        public static string FindFirstGreaterThanN(int n)
        {
            string answer = "";
            for (int i = 1; i <= n; i++)
            {
                if (i * i > n)
                {
                    answer += n.ToString();
                    break;
                }
                answer += (i * i) + " ";
            }

            return answer;
        }


        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите число");
                var n = int.Parse(Console.ReadLine());

                Console.WriteLine(Logic.FindFirstGreaterThanN(n));


            }
        }
    }
}