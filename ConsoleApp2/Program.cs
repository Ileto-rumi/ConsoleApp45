namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University();
            university.AddStudent(new Student("Penka", 99));
            university.AddStudent(new Student("Gosho", 92));
            university.AddStudent(new Student("Mimi", 56));
            university.AddStudent(new Student("Evgeni", 88));
            university.AddStudent(new Student("Kalina", 74));
            university.AddStudent(new Student("Lili", 30));

            Console.WriteLine("Vuvedete tyrseniq bal: ");
            int bal = int.Parse(Console.ReadLine());

            Console.WriteLine($"Studenta s bal {bal}: {university.FindStudentByScore(bal)}");
            
        }
    }
}
