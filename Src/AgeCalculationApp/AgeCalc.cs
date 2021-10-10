using System;
using System.Collections.Generic;

namespace AgeCalculationApp
{
    public class BirthYear
    {
            public BirthYear()
            {
                yearOfBirth = new List<int>();
            }

            public void addYearOfBirth(int age)
            {   
              try{ if(age < 1900 || age > 2021)
                {
                    throw new FormatException();
                }
                else {
                     yearOfBirth.Add(age);
                }
              }
              catch(FormatException e){
                  Console.WriteLine(e.Message);
              }
               
            }

            public List<int> calculateAge()
            {
                var ageStore  = new List<int>();
                foreach(var year in yearOfBirth)
                {
                    ageStore.Add(2021 - year);
                }
                

                return ageStore;
            }

    public AgeStatistics CalculateAgeStatistics()
        {
            var statistics = new AgeStatistics();
            var ageStore =  calculateAge();
            var temp = 0;
            var count= 0;
            statistics.DoubleAge = new List<int>();
            statistics.Average = 0.00;
            statistics.TotalAge = 0.00;

            // Loop through age data
            foreach (var age in ageStore)
            {
                statistics.TotalAge += age;
                temp = age * 2;
                statistics.DoubleAge.Add(temp);
               count++;
               
                
            }
            statistics.Average = statistics.TotalAge / count;
            return statistics;   
        }
            
    public void GetAgeStatistics()
    {
        var age = calculateAge();
        var statistics = CalculateAgeStatistics();
        foreach (var doubles in statistics.DoubleAge)
        {
            Console.WriteLine($"The double of age {doubles/2} is {doubles}");
        }
        Console.WriteLine($"The Total Calculation of all age equals(=): {statistics.TotalAge} ");
        Console.WriteLine($"The Total Average Calculation of all age equals(=): {statistics.Average:N2} ");
        
    }
        public int ageDataCount()
        {
            var age = calculateAge();
            return age.Count;
        }
        private List<int>yearOfBirth;
    }
}