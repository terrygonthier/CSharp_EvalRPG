using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvalRpgLib.Beings;
using EvalRpgLib.Exemples;
using EvalRpgLib.Helpers;

namespace EvalRpgTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestUnitAttaqueKO()
        {
            Unit A = new Unit("test_A");
            Unit B = new Unit("test_B");

            Assert.IsFalse(A.Attack(B));
        }

        [TestMethod]
        public void TestUnitAttaqueOK() {
            Unit A = new Unit("test_A", null, null, new BasicSword());
            Unit B = new Unit("test_B", null, null, new BasicSword());
            A.StatManager = new StatManager(A, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            B.StatManager = new StatManager(B, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            A.StatManager.Update();
            B.StatManager.Update();

            Assert.IsTrue(A.Attack(B));
        }

        [TestMethod]
        public void TestTakeDamage(){
            Unit A = new Unit("test_A", null, null, new BasicSword());
            A.StatManager = new StatManager(A, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            A.StatManager.Update();
            Assert.AreEqual(700, A.TakeDamage(1000, false, A));
        }

        [TestMethod]
        public void TestGetCurrentStat() {
            Unit A = new Unit("test_A", null, null, new BasicSword());
            A.StatManager = new StatManager(A, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            A.StatManager.Update();
            Assert.AreEqual(1100, A.GetCurrentStat(StatisticsEnum.Health));
        }

        [TestMethod]
        public void TestGetCurrentAttribute() {
            Unit A = new Unit("test_A", null, null, new BasicSword());
            A.StatManager = new StatManager(A, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            A.StatManager.Update();
            Assert.AreEqual(100, A.GetCurrentAttribute(AttributeEnum.Intelligence));
        }
    }
}
