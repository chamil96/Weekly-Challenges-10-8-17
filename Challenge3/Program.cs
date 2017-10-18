//3. Create a new dictionary called roadtohire that holds yourself, name and age(example "Nancy", 22). 
//Add each student in your class to the dictionary, as well as a random student, and display your total number of students.
//Once you have done that remove the random student from your roadtohire dictionary, and display your current number of students.
//Finally find yourself in the dictionary and display your name and your age.
using System;
using System.Collections.Generic;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> roadtohire = new Dictionary<string, int>
            {
                { "Chris", 21 },
                { "Malik", 21 },
                { "Miguel", 21 },
                { "Victoria", 23 },
                { "Lesly", 18 },
                { "Ivan", 18 },
                { "Angel", 19 },
                { "Hunter", 19 },
                { "Mickey", 19 },
                { "Teia", 23 },
                { "Brittany", 23 },
                { "Ian", 20 },
                { "Juan", 19 },
                { "Markus", 18 },
                { "Kalvin", 38 }
            };
            Console.WriteLine("Here's the total number of students in Road to Hire");
            int studentTotal = roadtohire.Count;
            Console.WriteLine(studentTotal);
            Console.WriteLine("We seem to have a random student let's correct this.");

            roadtohire.Remove("Kalvin");

            Console.WriteLine("Random student has been removed, here's the new count");
            int newStudentCount = roadtohire.Count;
            Console.WriteLine(newStudentCount);


            if (roadtohire.ContainsKey("Chris"))
            {
                var student = roadtohire["Chris"];
                Console.WriteLine(student);
            }
        }
    }
}
