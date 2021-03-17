using System;

namespace GraphicsLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                var imgInfo = new ImagesInfo(args[0]);
                imgInfo.OnGetInfo += ReadFile_Event;
                while (true)
                {
                    Console.WriteLine("1 - ввести промежуток, 2 - ввести имя файла, exit - выход.");
                    string cmd = Console.ReadLine();
                    switch (cmd)
                    {
                        case "1":
                            Console.Write("Введите a: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Введите b: ");
                            int b = int.Parse(Console.ReadLine());
                            imgInfo.GetFilesByRange(a, b);
                            break;
                        case "2": 
                            Console.Write("Введите имя файла");
                            string name = Console.ReadLine();
                            imgInfo.GetFilesByName(name);
                            break;
                        case "exit":
                            return;
                    }
                }
                
            }
        }

        static void ReadFile_Event(object sender, ElementInfoEventArgs e)
        {
            Console.WriteLine($"File name: {e.FileName}");
            Console.WriteLine($"Size: width = {e.SizeX}, height = {e.SizeY}");
            Console.WriteLine($"DPI: {(int)Math.Round(e.Resolution)}");
            Console.WriteLine($"Color Depth: {e.Depth}");
            Console.WriteLine($"Compression: {e.ImageСompression}");
            Console.WriteLine("=====================================");

        }
    }
}
