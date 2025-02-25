namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayCreator.CreateArray(10, false);
            Console.WriteLine("Masiv: " + string.Join(", ", array));

            int key = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Kluch: " + key);

            int index1 = LinearSearchWithTransposition(array, key);
            Console.WriteLine("Sled transortirane: " + string.Join(", ", array));
            Console.WriteLine("Index: " + index1);
            
        }

        public static int LinearSearchWithTransposition(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    if (i > 0)
                    {
                        (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                    }
                    return i - 1;
                }
            }
            return -1;
        }
    }
}
