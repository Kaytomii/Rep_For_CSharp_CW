//namespace CW_3_CS;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 3, 7, 1, 9, 5 };

//        Console.WriteLine("Array with int");

//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.WriteLine($"Element on index: {i} = {arr[i]}");
//        }

//        Console.WriteLine("Enter number: ");
//        short user_number = Convert.ToInt16(Console.ReadLine());

//        int index_el = Array.IndexOf(arr, user_number);

//        if (index_el == -1)
//        {
//            Console.WriteLine("Not in array");
//        }
//        else
//        {
//            Console.WriteLine("It is in array");
//            Console.WriteLine($"Index of number {index_el}");
//        }

//        Console.WriteLine("Array with double");
//        double[] arr_2 = { 3.5, 4.0, 9.2, 4.2, 3.4, 2.7 };

//        double sum = arr_2.Sum();
//        double average = arr_2.Average();
//        double min = arr_2.Min();
//        double max = arr_2.Max();

//        Console.WriteLine($"Sum of all elemnt: {Math.Round(sum, 2)}");
//        Console.WriteLine($"Average of all element: {Math.Round(average, 2)}");
//        Console.WriteLine($"Min element: {min}");
//        Console.WriteLine($"Max element: {max}");
//    }
//}
