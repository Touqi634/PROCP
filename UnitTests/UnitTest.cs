using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;
using FireSimulation;
using System.Drawing;

namespace UnitTests
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void GetNumberOfPeople()
        {
            var sut = new FireSimulation.SimulationManager();
            var value = sut.NumberOfPeople();
            Assert.AreEqual("0", value);
        }

       

        [Test]
        public void FireTimer()
        {
            var sut = new FireSimulation.Simulation();
            var value = sut.setFireTimer(5);
            Assert.IsFalse(value);
        }

        [Test]
        public void GradeCalculation()
        {

            Results mock1 = new Results(10, 2);
            Results mock2 = new Results(15, 4);
            Results mock3 = new Results(20, 6);
            List<Results> reslt = new List<Results>();
            reslt.Add(mock1);
            reslt.Add(mock2);
            reslt.Add(mock3);

            List<int> newexits = new List<int>();
            newexits.Add(1);
            newexits.Add(2);
            newexits.Add(3);


            var sut = new FireSimulation.StatisticsForm(reslt, "10", 50, newexits);
            var value = sut.CalculateGrade(50);
            Assert.AreEqual("Moderate", value);
        }

       

    }
}
