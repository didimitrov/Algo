using System;
using Computers.UI.Console.Components;
using Computers.UI.Console.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerBuilding.Tests
{
    [TestClass]
    public class BatteryChargeTest
    {
        private IRechargable _battery;

        [TestInitialize]
        public void CreateVBattery()
        {
            this._battery = new Battery();
        }

        [TestMethod]
        public void TestInitialCharge()
        {
            Assert.AreEqual(50, this._battery.CurrentCharge);
        }

        [TestMethod]
        public void ChargeWithHigherThanTheMaxChargeShoudSetChargeTo100()
        {
            this._battery.Charge(200);
            var expected = 100;

            Assert.AreEqual(expected, _battery.CurrentCharge);
        }

        [TestMethod]
        public void ChargeWithLowerThanTheMinChargeShoudSetChargeTo0()
        {
            _battery.Charge(-200);
            Assert.AreEqual(0, _battery.CurrentCharge);
        }

        [TestMethod]
        public void ChargeWithPOsitiveValueShoudIncreseTheChargePercentage()
        {
            var chargeValue = this._battery.CurrentCharge;
            this._battery.Charge(20);

            Assert.IsTrue(chargeValue<this._battery.CurrentCharge);
        }

        [TestMethod]
        public void ChargeWithNegativeValueShoudDecreseTheChargePercentage()
        {
            var chargeValue = this._battery.CurrentCharge;
            this._battery.Charge(-20);

            Assert.IsTrue(chargeValue > this._battery.CurrentCharge);
        }

        [TestMethod]
        public void ChargingWithZeroShoudNotChangeTheInitialCharge()
        {
            var chargeValue = this._battery.CurrentCharge;
            this._battery.Charge(0);

            Assert.AreEqual(chargeValue, this._battery.CurrentCharge);
        }


    }
}