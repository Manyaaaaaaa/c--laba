static void Main()
        {
            int m;
            Console.WriteLine("Input size of array:");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Rotate 90 degrees
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[j, i] + "  ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[m - i - 1, j] + "  ");
                }
                Console.WriteLine(); 
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, m - j - 1] + "  ");
                }
                Console.WriteLine();
            }
        }
