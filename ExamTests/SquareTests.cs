using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExamSquare;

namespace Exam.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        public void t_2p_KonstruktorEsSideGet()
        {
            Square c1 = new Square(4.25);
            double expectedSide = 4.25;
            double actualSide = c1.Side;
            Assert.AreEqual(expectedSide, actualSide, "A Square konstruktora vagy get metódusa nem jól határozza meg az oldalt!");
        }

        [TestMethod()]
        public void t_2p_Perimeter()
        {
            Square c1 = new Square(4.3333);
            double expectedDistrict = 17.3332;
            double actualDistrict = c1.Perimeter;
            Assert.AreEqual(expectedDistrict, actualDistrict, 0.01, "A Square District tulajdonság get metódusa nem megfelelően működik!");
        }
        [TestMethod()]
        public void t_2p_Area()
        {
            Square c1 = new Square(4.25);
            double expectedArea = 18.0625;
            double actualArea = c1.Area;
            Assert.AreEqual(expectedArea, actualArea, 0.01, "A Square Area tulajdonság get metódusa nem megfelelően működik!");
        }
        [TestMethod()]
        public void t_2p_AreaToString()
        {
            Square c1 = new Square(4.25);

            string toString = c1.ToString();
            string roundedPrerimeter = Math.Round(c1.Perimeter, 2).ToString();
            string roundedArea = Math.Round(c1.Area, 2).ToString();

            bool haveArea = toString.Contains(roundedArea);

            Assert.IsTrue(haveArea, "A ToString metódus nem jeleníti meg a területet két tizedes jegy pontosságal.");
        }

        [TestMethod()]
        public void t_2p_PerimeterToString()
        {
            Square c1 = new Square(4.25);

            string toString = c1.ToString();
            string roundedPrerimeter = Math.Round(c1.Perimeter, 2).ToString();
            string roundedArea = Math.Round(c1.Area, 2).ToString();

            bool haveParimeter = toString.Contains(roundedPrerimeter);

            Assert.IsTrue(haveParimeter, "A ToString metódus nem jeleníti meg a kerületet két tizedes jegy pontossággal!");
        }

    }
}