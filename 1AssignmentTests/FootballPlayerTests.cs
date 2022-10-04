using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Assignment.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer player = new FootballPlayer { Id = 1, Name = "Haaland", Age = 22, ShirtNumber = 9 };        
        private FootballPlayer playerShortName = new FootballPlayer { Id = 1, Name = "H", Age = 22, ShirtNumber = 9 };
        private FootballPlayer playerNameNull = new FootballPlayer { Id = 1, Name = null, Age = 22, ShirtNumber = 9 };
        private FootballPlayer playerUnderAge = new FootballPlayer { Id = 1, Name = "Haaland", Age = 0, ShirtNumber = 9 };
        private FootballPlayer playerShirtOut = new FootballPlayer { Id = 1, Name = "Haaland", Age = 22, ShirtNumber = 150 };

        [TestMethod()]
        public void ToStringTest()
        {
            string playerToString = player.ToString();
            Assert.AreEqual("1 Haaland 22 9", playerToString);
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            player.ValidateName();
            Assert.ThrowsException<ArgumentNullException>(() => playerNameNull.ValidateName());
            Assert.ThrowsException<ArgumentException>(() => playerShortName.ValidateName());
        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            player.ValidateAge();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerUnderAge.ValidateAge());
        }

        [TestMethod()]
        public void ValidateShirtNumberTest()
        {
            player.ValidateShirtNumber();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShirtOut.ValidateShirtNumber());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            player.Validate();
            Assert.ThrowsException<ArgumentNullException>(() => playerNameNull.Validate());
            Assert.ThrowsException<ArgumentException>(() => playerShortName.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerUnderAge.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShirtOut.Validate());
        }
    }
}