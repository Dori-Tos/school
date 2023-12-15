using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using school.Classes;
using Newtonsoft.Json;
//using static Android.Provider.MediaStore;

namespace school.Services
{
    public class DataManager
    {
        
        private List<Teacher> Teachers { get; } = new List<Teacher>();
        private List<Student> Students { get; } = new List<Student>();
        private List<Activity> Activities { get; } = new List<Activity>();

        private String path = "C:\\Users\\ecam\\Downloads\\saveTeacher.json";
        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
            try
            {
                SimpleWrite(teacher, path);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        public static void SimpleWrite(object obj, string fileName)
        {
            var jsonString = JsonConvert.SerializeObject(obj);
            File.WriteAllText(fileName, jsonString);
        }

    }

    
}
