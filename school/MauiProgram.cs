using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Newtonsoft.Json;
using school.Classes;

namespace school
{
    

    public static class MauiProgram
    { 
        static void CreateAndFillJsonFile(Teacher teacher, string filePath)
             {
        string jsonContent = JsonConvert.SerializeObject(teacher);

        // Écrire le contenu JSON dans le fichier
        File.WriteAllText(filePath, jsonContent);
    }
    
        public static MauiApp CreateMauiApp()
        {
     
            Teacher teacher = new Teacher("Quentin", "Lurkin", 5000);

            string jsonFilePath = "C:\\Users\\ecam\\Downloads\\saveTeacher.json";
            CreateAndFillJsonFile(teacher, jsonFilePath);

            Console.WriteLine("Fichier JSON créé avec succès !");
        

 
        var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
