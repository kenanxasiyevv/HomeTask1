namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            int number = int.Parse(Console.ReadLine());
            int r = 0;
            int sum = 0;

            while (number >= 10)
            {
                r = number % 10;
                number /= 100;

                sum += r * r;


            }
            Console.WriteLine(sum);

        }
    }
}