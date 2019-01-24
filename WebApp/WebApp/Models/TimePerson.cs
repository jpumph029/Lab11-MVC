using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class TimePerson
    {

        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        public static List<TimePerson> GetPersons(int firstYear, int secondYear )
        {
            string path = @"C:\Users\pumph\codefellows\401\Lab11-MVC\WebApp\WebApp\wwwroot\personOfTheYear.csv";
            List<TimePerson> people = new List<TimePerson>();

            string[] data = File.ReadAllLines(path);
            for (int i = 1; i < data.Length; i++)
            {
                var field = data[i].Split(",");

                    TimePerson timePeople = new TimePerson();
               
                    timePeople.Year = (field[0] == "") ? 0 : Convert.ToInt32(field[0]);
                    timePeople.Honor = field[1];
                    timePeople.Name = field[2];
                    timePeople.Country = field[3];
                    timePeople.BirthYear = (field[4] == "") ? 0 :Convert.ToInt32(field[4]);
                    timePeople.DeathYear = (field[5] == "") ? 0 :Convert.ToInt32(field[5]);
                    timePeople.Title = field[6];
                    timePeople.Category = field[7];
                    timePeople.Context = field[8];
                    people.Add(timePeople);    
            }
            List<TimePerson> filteredPeople = people.Where(p => (p.Year >= firstYear) && (p.Year <= secondYear)).ToList();
            return filteredPeople;
        }
    }
}
