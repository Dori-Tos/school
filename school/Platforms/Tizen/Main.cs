using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;
using school.Classes;

namespace school
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
            Console.WriteLine("app run");
            File.WriteAllText("C:\Users\ecam\Downloads\saveTeacher.json", "test d'écriture en json");
            Console.WriteLine("file written");
            Teacher Lur = new Teacher("Quentin", "Lurkin", 5000);
        }
    }
}
