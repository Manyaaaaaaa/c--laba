static void Main()
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Input x1 coordinate:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input y1 coordinate:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input x2 coordinate:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input y2 coordinate:");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x1 == x2 || y1 == y2 ? true : false);
        }
