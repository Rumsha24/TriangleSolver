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



        [Test]
        public void isoscelesTriangleTest1()
        {
            // Arrange
            int firstSide = 15;
            int secondSide = 15;
            int thirdSide = 8;
            // Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }
        [Test]

        public void isoscelesTriangleTest2()
        {
            // Arrange
            int firstSide = 18;
            int secondSide = 20;
            int thirdSide = 12;
            // Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert


        }


        [Test]

        public void isoscelesTriangleTest3()
        {
            // Arrange
            int firstSide = 22;
            int secondSide = 20;
            int thirdSide = 9;
            // Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert


        }
    }


}