using System;
using Computers.UI.Console;
using Computers.UI.Console.Components;
using Computers.UI.Console.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ComputerBuilding.Tests
{
    [TestClass]
    public class CpuRandomTest
    {
        private ICpu cpu;
        private int mockedRamValue;

        [TestInitialize]
        public void CreateCpu()
        {
            var mockedRam = new Mock<IRam>();
            mockedRam.Setup(r => r.SaveValue(It.IsAny<int>())).Callback((int value) => this.mockedRamValue = value);

            var mockedVideoCard = new Mock<IVideoCard>();

            this.cpu = new Cpu( mockedRam.Object, mockedVideoCard.Object,4,CpuArchitecture.Bit128);
        }

        [TestMethod]
        public void GenerateRandomFromCpuShoudSaveNumberToRam()
        {
            this.cpu.GenerateRandom(1, 10);
            Assert.IsNotNull(this.mockedRamValue);
        }

        [TestMethod]
        public void GeneratedRandomNumberBetweenTwoSameNumbersShoudReturnSameNumber()
        {
            this.cpu.GenerateRandom(2, 2);
            Assert.AreEqual(2, this.mockedRamValue);
        }

        [TestMethod]
        public void GeneratedRandomNumberShoudBeInGivenRange()
        {
            const int MinValue = 5;
            const int MaxValue = 50;
            this.cpu.GenerateRandom(MinValue, MaxValue);
            Assert.IsTrue(MinValue <= this.mockedRamValue);
            Assert.IsTrue(this.mockedRamValue <= MaxValue);
        }

        [TestMethod]
        public void GeneratedRandomNumberBetweenTwoАdjacentNumbersShoudReturnOneOrTheOther()
        {
            this.cpu.GenerateRandom(2, 3);
            bool firstNumber = this.mockedRamValue == 2 && this.mockedRamValue != 3;
            bool secondNumber = this.mockedRamValue != 2 && this.mockedRamValue == 3;

            Assert.IsTrue(firstNumber || secondNumber);
        }
    }
}
