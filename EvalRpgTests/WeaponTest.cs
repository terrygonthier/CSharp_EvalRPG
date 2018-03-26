using System;
using EvalRpgLib.Beings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvalRpgTests
{
    [TestClass]
    public class WeaponTest
    {
        [TestMethod]
        public void TestWeaponOK()
        {
            Weapon weapon = new Weapon("Awesome Blade", true);
            Assert.AreEqual("Awesome Blade", weapon.Name);
            Assert.AreEqual(true, weapon.IsMagic);
        }
    }
}
