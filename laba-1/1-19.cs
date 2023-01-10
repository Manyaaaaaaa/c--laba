static void Main(string[] args)
        {
            int r1, r2, r3;
            Console.WriteLine("Input r1:");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input r2:");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input r3:");
            r3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total resistance: {r1+r2+r3}");
        }
