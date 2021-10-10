using System;
using Xunit;

namespace AgeCalculationApp.Test
{
    public class AgeCalculationTest
    {
      
        [Fact]
        public void Test1()
        {
            var agetest = new BirthYear();
                
            agetest.addYearOfBirth(3001);
            agetest.addYearOfBirth(4784);
            
            Assert.Equal(0,agetest.ageDataCount());
        }
    }
}
