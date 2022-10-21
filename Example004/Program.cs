// написать программу копирования массива
 int[] arr = { 10, 4, 7, 3, 12 };
 
        int[] copy = new int[arr.Length];
        arr.CopyTo(copy, 0);
 
        Console.WriteLine(String.Join(", ", copy));
