namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee("FName", "LName", 100);
            //emp.print();

            //Console.WriteLine("------------------------------------------");

            //emp = new Employee("Ivan", "Ivanoff", DateTime.Now, 200);
            //emp.print();

            //Console.WriteLine("------------------------------------------");

            //Employee manager = new Manager("Piotr", "Piotroff", new DateTime(1995, 7, 10), 500, "Soil");

            //Employee[] emps =
            //{
            //    manager,
            //    new Scientist ("Volololodimir", "Hulkoff", new DateTime(1959, 10, 7), 1000, "Math"),
            //    new Scientist ("Jora", "Eotoff", new DateTime(1969, 6, 9), 2000, "Math")
            //};

            //foreach (Employee employee in emps)
            //{
            //    employee.print();
            //    try
            //    {
            //        ((Manager)employee).ShowManager();
            //    }
            //    catch { }
            //    //-----------------------------------------------------------
            //    Scientist scientist = employee as Scientist;

            //    if (scientist != null)
            //        scientist.ShowScientist();
            //    //----------------------------------------------------------
            //    if (employee is Manager)
            //        (employee as Manager).ShowManager();


            /*
            FibNumber num1 = new FibNumber();
            num1.print();
            Console.WriteLine("--------------------------------");

            Rectangle rect = new Rectangle('*', 10, 5);

            rect.draw();
            Console.WriteLine();

            Square sqr = new Square('*', 5);
            sqr.draw();

            Console.WriteLine();

            Triangle trg = new Triangle('*', 5);
            trg.draw();


            Console.WriteLine("--------------------------------");
            */
            /*
            GuessNumber game = new GuessNumber(0, 100);
            Console.WriteLine("Введите загаданное число: ");
            int target = int.Parse(Console.ReadLine());
            game.SetTarget(target);
            game.Guess();
            Console.WriteLine($"Компьютер угадал число за {game.GetIterations()} итераций.");

            Console.WriteLine("--------------------------------");
            */
            Console.WriteLine("Введите максимальное количество гласных: ");
            int maxVowels = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное количество согласных: ");
            int maxConsonants = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную длину слова: ");
            int maxLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество слов в предложении: ");
            int numWords = int.Parse(Console.ReadLine());

            PseudoTextGenerator generator = new PseudoTextGenerator(maxVowels, maxConsonants, maxLength);
            Console.WriteLine($"Сгенерированное псевдопредложение: {generator.GenerateSentence(numWords)}");


        }
    }
}
