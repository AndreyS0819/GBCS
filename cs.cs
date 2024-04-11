using System;

namespace Tasks
{
    public class Task1
    {
        static string SumNumbers(int M, int N)
        {
            if (M == N) return M.ToString();                                 // Если M=N
            else if (M > N) Console.WriteLine("M должно быть меньше N!!!");  // Если M<N
            else return M.ToString() + ", " + SumNumbers(M + 1, N);          // Если M>N
            return "err";
        }

        static public void m()
        {
            Console.Write("M = ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"Result, S = {SumNumbers(M, N)}");
            Console.ReadLine();
        }
    }



    public class Task2
    {
        static int r(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 & n == 0)
            {
                return r(m - 1, 1);
            }
            else
            {
                return r(m - 1, r(m, n - 1));
            }
            return 0;
        }

        static public void m()
        {
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            int result = r(m, n);

            Console.WriteLine("A(m,n)=" + result);
        }
    }



    public class Task3
    {
        static string F(string[] arr, int i)
        {
            if (i < arr.Length)
            {
                return arr[arr.Length - i] + F(arr, i + 1);
            }
            return arr[0];
        }

        static public void m()
        {
            Console.Write("Введите массив:");
            string str = Console.ReadLine();

            string[] arr = str.Split(',');

            int i = 0;
            Console.WriteLine($"Result, S = {F(arr, 1)}");
        }
    }

    public class start
    {
        public static void Main(string[] args)
        {
            Console.Write("Choose a task (Task1/Task2/Task3):");
            string task = Console.ReadLine();

            switch (task.ToLower())
            {
                case "task1":
                    Task1.m();
                    break;
                case "task2":
                    Task2.m();
                    break;
                case "task3":
                    Task3.m();
                    break;
            }

        }
    }
}