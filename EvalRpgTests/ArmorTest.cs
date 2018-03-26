using System;
using EvalRpgLib.Beings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvalRpgTests
{
    [TestClass]
    public class ArmorTest
    {
        [TestMethod]
        public void TestArmorOK() {
            Armor armor = new Armor("Awesome armor", ArmorType.Chest, 3);
            Assert.AreEqual("Awesome armor", armor.Name);
            Assert.AreEqual(ArmorType.Chest, armor.Type);
            Assert.AreEqual(3, armor.Amount);
        }
    }
}
