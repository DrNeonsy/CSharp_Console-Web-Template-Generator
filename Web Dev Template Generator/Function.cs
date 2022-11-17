namespace Web_Dev_Template_Generator
{
    internal class Function
    {
        internal static void GenerateStructure(char template)
        {
            Console.Clear();

            CreateDirectory(App.path, @"assets/icons");
            if (template == 'b')
            {
                CreateFile(App.path, @"index.html", Resource.beginner_index);
                CreateFile(App.path, @"assets/icons/fav.png", Resource.beginner_fav);
            }
            else if (template == 'i')
            {
                CreateDirectory(App.path, @"assets/images");
                CreateDirectory(App.path, @"css/scss");
                CreateFile(App.path, @"index.html", Resource.intermediate_index);
                CreateFile(App.path, @"assets/icons/fav.png", Resource.intermediate_fav);
                CreateFile(App.path, @"assets/images/background.jpg", Resource.intermediate_background);
                CreateFile(App.path, @"css/main.css", Resource.intermediate_main);
                CreateFile(App.path, @"css/scss/main.scss", Resource.intermediate_main_scss);
                CreateFile(App.path, @"css/scss/_global.scss", Resource.intermediate_global);
            }
            else if (template == 'a')
            {
                CreateDirectory(App.path, @"assets/images");
                CreateDirectory(App.path, @"assets/downloads");
                CreateDirectory(App.path, @"css/scss");
                CreateDirectory(App.path, @"js");
                CreateDirectory(App.path, @"inc");
                CreateDirectory(App.path, @"errors");
                CreateFile(App.path, @"index.php", Resource.advanced_index);
                CreateFile(App.path, @"inc/head.php", Resource.advanced_head);
                CreateFile(App.path, @"assets/icons/fav.png", Resource.advanced_fav);
                CreateFile(App.path, @"assets/images/background.jpg", Resource.advanced_background);
                CreateFile(App.path, @"css/main.css", Resource.advanced_main);
                CreateFile(App.path, @"css/scss/main.scss", Resource.advanced_main_scss);
                CreateFile(App.path, @"css/scss/_global.scss", Resource.advanced_global);
                CreateFile(App.path, @"js/app.js", Resource.advanced_app);
            }
        }
        internal static void ProgressMessage(string sub, string type)
        {
            Console.WriteLine("{0, -18} {1, -18} {2, -9} {3}", "Generating:", type, "@", sub);
            Thread.Sleep(120);
        }
        internal static void CreateDirectory(string path, string sub)
        {
            Directory.CreateDirectory(path + sub);
            ProgressMessage(sub, "Directory");
        }
        internal static void CreateFile(string path, string sub, byte[] file)
        {
            File.WriteAllBytes(path + sub, file);
            ProgressMessage(sub, "File");
        }
        internal static void CreateFile(string path, string sub, string file)
        {
            File.WriteAllText(path + sub, file);
            ProgressMessage(sub, "File");
        }
        internal static void CheckFolder()
        {
            if (Directory.Exists(App.path))
            {
                Console.Clear();
                Console.WriteLine(Resource.Error);
                Console.WriteLine("A Directory Called \"www\" Does Already Exist.\nPlease Fix That And Try Again.");
                Thread.Sleep(5400);
                Environment.Exit(0);
            }
        }
    }
}
