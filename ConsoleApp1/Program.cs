namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayCreator2.CreateArray(10, false);
            Console.WriteLine("Масив: " + string.Join(", ", array));

            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("Kluch: " + key);

            int index = LinearSearchWithMoveToFront(array, key);
            Console.WriteLine("Sled premestvane nai-otpred: " + string.Join(", ", array));
            Console.WriteLine("Index: " + index);

        }
        public static int LinearSearchWithMoveToFront(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    (arr[i], arr[0]) = (arr[0], arr[i]);
                    return i;
                }
            }
            return -1;
        }
    }
}
