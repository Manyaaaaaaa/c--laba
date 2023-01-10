static void Main()
        {
            int r, n, min, temp1 = 0, temp2 = 0;
            Console.WriteLine("Input size of array:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input number(R):");
            r = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            min = Math.Abs(r - (arr[0] + arr[0]));
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(r - (arr[0] + arr[0])) < min) {
                        temp1 = i;
                        temp2 = j;
                    }
                }
            }
            Console.WriteLine($"{arr[temp1]}+{arr[temp2]} closest to {r}");
        }
