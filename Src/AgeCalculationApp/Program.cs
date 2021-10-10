using System;
using System.Collections.Generic;

namespace AgeCalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ageData = new BirthYear();
            var done = false;
            while(done == false)
            {
               try{ Console.WriteLine("Enter Years of Birth or 1 to quit");
                var input = Console.ReadLine();
                var parsedInput = int.Parse(input);
                if(input == "1")
                {
                    done = true;
                }
                
                else if(parsedInput < 1900 || parsedInput > 2021)
                {
                    Console.WriteLine("Enter a Year Between 1900 and 2021");
                }

                else{
                   
                    ageData.addYearOfBirth(parsedInput);
                }
                
               }
               catch{
                   Console.WriteLine("Enter an Integer between 1900- 2021");
               }

            }
            ageData.calculateAge();
            ageData.GetAgeStatistics();
        }

      
    }
}
