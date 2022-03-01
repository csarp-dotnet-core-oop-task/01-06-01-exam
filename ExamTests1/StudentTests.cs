using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolEnrollmentProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolEnrollmentProject.Tests
{
    [TestClass()]
    public class PointSummaryTest
    {
        [TestMethod()]
        public void t1p_PointSummaryTestMath()
        {
            PointSummary josephScore = new PointSummary(83, 94);
            int expected = 83;
            int actual = josephScore.MathScore;
            Assert.AreEqual(expected, actual, "A matematikai pontot a konstruktor vagy a getter nem jól határozza meg.");
        }

        [TestMethod()]
        public void t1p_PointSummaryTestLanguage()
        {
            PointSummary josephScore = new PointSummary(83, 94);
            int expected = 94;
            int actual = josephScore.LanguageScore;
            Assert.AreEqual(expected, actual, "A magyar nyelv pontot a konstruktor vagy a getter nem jól határozza meg.");
        }
    }
    [TestClass()]
    public class StudentTest
    {
        [TestMethod()]
        public void t1p_StudentTestTestName()
        {
            PointSummary josephScore = new PointSummary(83, 94);
            Student joseph = new Student("József", josephScore);
            string expected = "József";
            string actual = joseph.Name;
            Assert.AreEqual(expected, actual, "A nevet a konstruktor vagy a getter nem jól határozza meg");
        }
        [TestMethod()]
        public void t1p_StudentTestTestTotalPoint()
        {
            PointSummary josephScore = new PointSummary(83, 94);
            Student joseph = new Student("József", josephScore);
            int expected = 83 + 94;
            int actual = joseph.TotalScore;
            Assert.AreEqual(expected, actual, "A felvételi pontot pontot a a getter nem jól határozza meg.");
        }
    }



}