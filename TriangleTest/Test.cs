using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace TestClass
{
    [TestFixture]
    public class Test
    {
        [Test]
      public void equilaterialTriangleTest()
        {

            // Arrange
            int firstSide = 13;
            int secondSide = 13;
            int thirdSide = 13;
            // Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual("Equilateral triangle", result);
        








    }
    }
}
