using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap vao so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("So phan tu khong hop le.");
            return;
        }
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        int max = arr[0]; 
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                maxIndex = i;
            }
        }
        Console.WriteLine($"Phan tu lon nhat trong mang la {max} va nam o vi tri {maxIndex + 1} trong mang.");
    }
}

