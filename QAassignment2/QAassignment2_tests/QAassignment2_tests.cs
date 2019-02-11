using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QAassignment2;
using NUnit.Framework;


namespace QAassignment2_tests
{
    [TestFixture]
    class QAassignment2_tests
    {
        [Test]
        public void Analyze_input3x3x3_expectedResultEqualsEquilateral()
        {

            int dimension1 = 3;
            int dimension2 = 3;
            int dimension3 = 3;
            string testResult = "Triangle with " + dimension1 + ", " + dimension2 + ", " + dimension3 + " sides is equilateral\n";

            string result = TriangleSolver.Analyze(dimension1, dimension2, dimension3);

            Assert.AreEqual(testResult, result);

        }

        [Test]
        public void Analyze_input6x6x10_expectedResultEqualsIsosceles()
        {

            int dimension1 = 6;
            int dimension2 = 6;
            int dimension3 = 10;
            string testResult = "Triangle with " + dimension1 + ", " + dimension2 + ", " + dimension3 + " sides is isosceles\n";

            string result = TriangleSolver.Analyze(dimension1, dimension2, dimension3);

            Assert.AreEqual(testResult, result);

        }

        [Test]
        public void Analyze_input6x10x6_expectedResultEqualsIsosceles()
        {

            int dimension1 = 6;
            int dimension2 = 10;
            int dimension3 = 6;
            string testResult = "Triangle with " + dimension1 + ", " + dimension2 + ", " + dimension3 + " sides is isosceles\n";

            string result = TriangleSolver.Analyze(dimension1, dimension2, dimension3);

            Assert.AreEqual(testResult, result);

        }

        [Test]
        public void Analyze_input10x6x6_expectedResultEqualsIsosceles()
        {

            int dimension1 = 10;
            int dimension2 = 6;
            int dimension3 = 6;
            string testResult = "Triangle with " + dimension1 + ", " + dimension2 + ", " + dimension3 + " sides is isosceles\n";

            string result = TriangleSolver.Analyze(dimension1, dimension2, dimension3);

            Assert.AreEqual(testResult, result);

        }

        [Test]
        public void Analyze_input1x2x3_expectedResultEqualsNotBuilt()
        {

            int dimension1 = 1;
            int dimension2 = 2;
            int dimension3 = 3;
            string testResult = "Triangle with " + dimension1 + ", " + dimension2 + ", " + dimension3 + " sides can not be built\n";

            string result = TriangleSolver.Analyze(dimension1, dimension2, dimension3);

            Assert.AreEqual(testResult, result);

        }

        [Test]
        public void Analyze_input30x20x10_expectedResultEqualsNotBuilt()
        {

            int dimension1 = 30;
            int dimension2 = 20;
            int dimension3 = 10;
            string testResult = "Triangle with " + dimension1 + ", " + dimension2 + ", " + dimension3 + " sides can not be built\n";

            string result = TriangleSolver.Analyze(dimension1, dimension2, dimension3);

            Assert.AreEqual(testResult, result);

        }

        [Test]
        public void Analyze_input4x3x5_expectedResultEqualsScalene()
        {

            int dimension1 = 4;
            int dimension2 = 3;
            int dimension3 = 5;
            string testResult = "Triangle with " + dimension1 + ", " + dimension2 + ", " + dimension3 + " sides is scalene\n";

            string result = TriangleSolver.Analyze(dimension1, dimension2, dimension3);

            Assert.AreEqual(testResult, result);

        }

        [Test]
        public void Analyze_input33x55x44_expectedResultEqualsScalene()
        {

            int dimension1 = 33;
            int dimension2 = 55;
            int dimension3 = 44;
            string testResult = "Triangle with " + dimension1 + ", " + dimension2 + ", " + dimension3 + " sides is scalene\n";

            string result = TriangleSolver.Analyze(dimension1, dimension2, dimension3);

            Assert.AreEqual(testResult, result);

        }
    }
}
