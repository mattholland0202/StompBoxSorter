using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SBS.BLL.Interfaces.Base;
using SBS.BLL.Tests.TestBase;
using SBS.DAL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.BLL.Tests
{
    [TestClass]
    public class PedalBllTests
    {
        private IBLL bll;

        private Manufacturer testManufacturer;
        private Pedal testPedal1;
        private Pedal testPedal2;
        private Pedal testPedal3;
        private Pedal testPedal4;
        private PedalImage testPedalImage;
        private PedalJack testPedalJack1;
        private PedalJack testPedalJack2;
        private PedalJackType testPedalJackType1;
        private PedalJackType testPedalJackType2;
        private PedalType testPedalType1;
        private PedalType testPedalType2;
        private PedalPowerConnection testPowerConnection;
        private User testCreator1;

        private List<Pedal> testPedals;
        private List<PedalImage> testPedalImages;
        private List<PedalJack> testPedalJacks;
        private List<PedalType> testPedalTypes;
        
        [TestInitialize]
        public void Setup()
        {
            Mock<IUnitOfWork> mockedUnitOfWork = new Mock<IUnitOfWork>();
            Mock<IReadWriteRepository<Pedal>> mockedPedalRepository = new Mock<IReadWriteRepository<Pedal>>();

            testManufacturer = new Manufacturer
            {
                ManufacturerID = 1,
                Name = "Test Manufacturer",
            };

            testPowerConnection = new PedalPowerConnection
            {
                Voltage = 10,
                IsDcPower = true,
                HasBatteryConnection = true,
            };

            testPedalJackType1 = new PedalJackType
            {
                Name = "Test Jack Type 1",
            };

            testPedalJack1 = new PedalJack
            {
                Type = testPedalJackType1,
                Name = "Test Pedal Jack 1",
            };

            testPedalJackType2 = new PedalJackType
            {
                Name = "Test Jack Type 2",
            };

            testPedalJack2 = new PedalJack
            {
                Type = testPedalJackType2,
                Name = "Test Pedal Jack 2",
            };

            testPedalJacks = new List<PedalJack>
            {
                testPedalJack1,
                testPedalJack2,
            };

            testCreator1 = new User
            {
                UserID = 1,
            };

            testPedalImage = new PedalImage
            {
                Image = new byte[1],
                IsMainImage = true,
                IsValidated = true,
                Creator = testCreator1,
            };

            testPedalImages = new List<PedalImage>
            {
                testPedalImage,
            };

            testPedal1 = new Pedal
            {
                PedalID = 1,
                Name = "Test Pedal 1",
                IsVerified = true,
            };

            testPedal2 = new Pedal
            {
                PedalID = 2,
                Name = "Test Pedal 2",
                IsVerified = true,
            };

            testPedal3 = new Pedal
            {
                PedalID = 3,
                Name = "Test Pedal 3",
                IsVerified = true,
            };

            testPedal4 = new Pedal
            {
                PedalID = 4,
                Name = "Test Pedal 4",
                IsVerified = false,
            };

            testPedalType1 = new PedalType
            {
                Name = "Test Type 1",
            };

            testPedalType2 = new PedalType
            {
                Name = "Test Type 2",
            };

            testPedalTypes = new List<PedalType>
            {
                testPedalType1,
                testPedalType2,
            };

            testPedals = new List<Pedal>
            {
                testPedal1,
                testPedal2,
                testPedal3,
                testPedal4,
            };

            mockedPedalRepository.Setup(m => m.GetAll())
                .Returns(testPedals);

            mockedPedalRepository.Setup(m => m.Add(It.IsAny<Pedal>()))
                .Callback((Pedal p) =>
                {
                    testPedals.Add(p);
                });

            mockedUnitOfWork.Setup(c => c.PedalRepository)
                .Returns(mockedPedalRepository.Object);
            
            bll = new Base.BLL(mockedUnitOfWork.Object);
        }

        [TestMethod]
        public void Test_GetAll()
        {
            var all = bll.Pedals.GetAll();
            Assert.AreEqual(4, all.Count());
        }

        [TestMethod]
        public void Test_GetAllVerified()
        {
            var all = bll.Pedals.GetAllVerified();
            Assert.AreEqual(3, all.Count());
        }

        [TestMethod]
        [ExpectedExceptionContainsMessage(typeof(ArgumentNullException), "name")]
        public void Test_Add_NullName()
        {
            bll.Pedals.Add(null, null, null, 100, 100, 100, false, null, null, null, null, null);
        }

        [TestMethod]
        [ExpectedExceptionContainsMessage(typeof(ArgumentNullException), "name")]
        public void Test_Add_EmptyName()
        {
            bll.Pedals.Add(String.Empty, null, null, 100, 100, 100, false, null, null, null, null, null);
        }

        [TestMethod]
        [ExpectedExceptionContainsMessage(typeof(ArgumentNullException), "shortName")]
        public void Test_Add_NullShortName()
        {
            bll.Pedals.Add("New Test Pedal", null, null, 100, 100, 100, false, null, null, null, null, null);
        }

        [TestMethod]
        [ExpectedExceptionContainsMessage(typeof(ArgumentNullException), "shortName")]
        public void Test_Add_EmptyShortName()
        {
            bll.Pedals.Add("New Test Pedal", String.Empty, null, 100, 100, 100, false, null, null, null, null, null);
        }

        [TestMethod]
        [ExpectedExceptionContainsMessage(typeof(ArgumentNullException), "manufacturer")]
        public void Test_Add_NullManufacturer()
        {
            bll.Pedals.Add("New Test Pedal", "NTP", null, 100, 100, 100, false, null, null, null, null, null);
        }

        [TestMethod]
        [ExpectedExceptionContainsMessage(typeof(ArgumentNullException), "powerConnection")]
        public void Test_Add_NullPowerConnection()
        {
            bll.Pedals.Add("New Test Pedal", "NTP", testManufacturer, 100, 100, 100, false, null, null, null, null, null);
        }

        [TestMethod]
        [ExpectedExceptionContainsMessage(typeof(ArgumentNullException), "types")]
        public void Test_Add_NullTypes()
        {
            bll.Pedals.Add("New Test Pedal", "NTP", testManufacturer, 100, 100, 100, false, testPowerConnection, null, null, null, null);
        }

        [TestMethod]
        [ExpectedExceptionContainsMessage(typeof(ArgumentException), "types")]
        public void Test_Add_EmptyTypes()
        {
            bll.Pedals.Add("New Test Pedal", "NTP", testManufacturer, 100, 100, 100, false, testPowerConnection, 
                new List<PedalType>(), null, null, null);
        }

        [TestMethod]
        [ExpectedExceptionContainsMessage(typeof(ArgumentNullException), "jacks")]
        public void Test_Add_NullJacks()
        {
            bll.Pedals.Add("New Test Pedal", "NTP", testManufacturer, 100, 100, 100, false, testPowerConnection, 
                testPedalTypes, null, null, null);
        }

        [TestMethod]
        [ExpectedExceptionContainsMessage(typeof(ArgumentException), "jacks")]
        public void Test_Add_EmptyJacks()
        {
            bll.Pedals.Add("New Test Pedal", "NTP", testManufacturer, 100, 100, 100, false, testPowerConnection,
                testPedalTypes, new List<PedalJack>(), null, null);
        }

        [TestMethod]
        [ExpectedExceptionContainsMessage(typeof(ArgumentNullException), "images")]
        public void Test_Add_NullImages()
        {
            bll.Pedals.Add("New Test Pedal", "NTP", testManufacturer, 100, 100, 100, false, testPowerConnection,
                testPedalTypes, testPedalJacks, null, null);
        }

        [TestMethod]
        [ExpectedExceptionContainsMessage(typeof(ArgumentException), "images")]
        public void Test_Add_EmptyImages()
        {
            bll.Pedals.Add("New Test Pedal", "NTP", testManufacturer, 100, 100, 100, false, testPowerConnection,
                testPedalTypes, testPedalJacks, new List<PedalImage>(), null);
        }

        [TestMethod]
        [ExpectedExceptionContainsMessage(typeof(ArgumentNullException), "creator")]
        public void Test_Add_NullCreator()
        {
            bll.Pedals.Add("New Test Pedal", "NTP", testManufacturer, 100, 100, 100, false, testPowerConnection,
                testPedalTypes, testPedalJacks, testPedalImages, null);
        }

        [TestMethod]
        public void Test_Add()
        {
            int initialCount = testPedals.Count;

            bll.Pedals.Add("New Test Pedal", "NTP", testManufacturer, 100, 100, 100, false, testPowerConnection,
                testPedalTypes, testPedalJacks, testPedalImages, testCreator1);

            Assert.AreEqual(initialCount + 1, testPedals.Count);
        }
    }
}
