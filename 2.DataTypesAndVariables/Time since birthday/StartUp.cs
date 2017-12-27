
namespace Time_since_birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double peopleNumber = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}",Math.Ceiling(peopleNumber / capacity));
        }
    }
}
