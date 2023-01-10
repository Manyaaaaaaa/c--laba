static void Main()
        {
            int n, m;
            double res = 0;
            Console.WriteLine("Input starting element of a number series(n):");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input ending element of a number series(m):");
            m = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i < m+1; i++)
            {
                res += (Math.Pow(-1, i) * Math.Pow(i, 2) - 1) / (Math.Pow(i, 2) + 3);
            }
            Console.WriteLine(res);
        }
