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

            int index1 = LineinoPurvi.LinearSearchWithTransposition(array, key);
            Console.WriteLine("Sled transortirane: " + string.Join(", ", array));
            Console.WriteLine("Index: " + index1);
            
        }
    }
}
