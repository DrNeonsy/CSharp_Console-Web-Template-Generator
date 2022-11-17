namespace Web_Dev_Template_Generator
{
    internal class App
    {
        // Creating The Base Path Which Is The Location Of The Application + www
        internal static string path = Directory.GetCurrentDirectory() + "/www/";

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            // Start Banner
            Console.WriteLine(Resource.Start);
            Thread.Sleep(3600); Console.Clear();

            // Menu
            Console.WriteLine("Please Select One Of The Following Options\n");

            Console.WriteLine("{0, -12} {1} {2}", "Beginner", "(B):", "For Those Who Are About To Start Their Journy.");
            Console.WriteLine("{0, -12} {1} {2}", "Intermediate", "(I):", "For Those Know Their HTML And Want To Start With The Styling.");
            Console.WriteLine("{0, -12} {1} {2}", "Advanced", "(A):", "For Those Who Can Create Websites In Their Image And Want To Go Deeper.");

            Console.WriteLine("\nPress Any Of The Three Keys To Generate The Template");

            // Waiting For Selection
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.B)
                {
                    Thread.Sleep(1200);
                    Function.CheckFolder();
                    Function.GenerateStructure('b');
                    break;
                }
                else if (key.Key == ConsoleKey.I)
                {
                    Thread.Sleep(1200);
                    Function.CheckFolder();
                    Function.GenerateStructure('i');
                    break;
                }
                else if (key.Key == ConsoleKey.A)
                {
                    Thread.Sleep(1200);
                    Function.CheckFolder();
                    Function.GenerateStructure('a');
                    break;
                }
            }

            Thread.Sleep(1200);
            Console.WriteLine(Resource.Done);
            Thread.Sleep(1800);
        }
    }
}