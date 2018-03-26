using System;
using System.Collections.Generic;
using EvalRpgLib.Beings;
using EvalRpgLib.Exemples;
using EvalRpgLib.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvalRpgTests
{
    [TestClass]
    public class StatManagerTest
    {
        [TestMethod]
        public void TestStatManagerOK() {
            Unit A = new Unit("test_A", null, null, new BasicSword());
            Dictionary<AttributeEnum, int> baseAttributes = StatHelper.GetDefaultAttributes();
            Dictionary<StatisticsEnum, Func<Unit, int>> statisticsComputer = StatHelper.GetDefaultComputer();
            StatManager statManager = new StatManager(A, baseAttributes, statisticsComputer);
            Assert.AreEqual(baseAttributes, statManager.BaseAttributes);
            Assert.AreEqual(statisticsComputer, statManager.StatisticsComputer);
            Assert.AreEqual(A, statManager.Unit);
        }

        [TestMethod]
        public void TestGetCurrentStatOK(){
            Unit A = new Unit("test_A", null, null, new BasicSword());
            Dictionary<AttributeEnum, int> baseAttributes = StatHelper.GetDefaultAttributes();
            Dictionary<StatisticsEnum, Func<Unit, int>> statisticsComputer = StatHelper.GetDefaultComputer();
            StatManager statManager = new StatManager(A, baseAttributes, statisticsComputer);

            Assert.AreEqual(0, statManager.GetCurrentStatistic(StatisticsEnum.Health));
        }

        [TestMethod]
        public void TestGetCurrentStatKO()
        {
            Unit A = new Unit("test_A", null, null, new BasicSword());
            Dictionary<AttributeEnum, int> baseAttributes = StatHelper.GetDefaultAttributes();
            Dictionary<StatisticsEnum, Func<Unit, int>> statisticsComputer = StatHelper.GetDefaultComputer();
            StatManager statManager = new StatManager(A, null, null);

            Assert.AreEqual(0, statManager.GetCurrentStatistic(StatisticsEnum.Health));
        }

        [TestMethod]
        public void TestGetCurrentAttributeOK()
        {
            Unit A = new Unit("test_A", null, null, new BasicSword());
            Dictionary<AttributeEnum, int> baseAttributes = StatHelper.GetDefaultAttributes();
            Dictionary<StatisticsEnum, Func<Unit, int>> statisticsComputer = StatHelper.GetDefaultComputer();
            StatManager statManager = new StatManager(A, baseAttributes, statisticsComputer);

            Assert.AreEqual(0, statManager.GetCurrentAttribute(AttributeEnum.Agility));
        }

        [TestMethod]
        public void TestGetCurrentAttributeKO(){
            Unit A = new Unit("test_A", null, null, new BasicSword());
            Dictionary<AttributeEnum, int> baseAttributes = StatHelper.GetDefaultAttributes();
            Dictionary<StatisticsEnum, Func<Unit, int>> statisticsComputer = StatHelper.GetDefaultComputer();
            StatManager statManager = new StatManager(A, null, null);

            Assert.AreEqual(0, statManager.GetCurrentAttribute(AttributeEnum.Agility));
        }

        [TestMethod]
        public void TestUpdateStatistic() {
            Unit A = new Unit("test_A", null, null, new BasicSword());
            Dictionary<AttributeEnum, int> baseAttributes = StatHelper.GetDefaultAttributes();
            Dictionary<StatisticsEnum, Func<Unit, int>> statisticsComputer = StatHelper.GetDefaultComputer();
            StatManager statManager = new StatManager(A, baseAttributes, statisticsComputer);
            A.StatManager = statManager;
            Assert.AreEqual(0, statManager.BaseStatistics.Count);
            Assert.AreEqual(0, statManager.CurrentStatistics.Count);
            statManager.UpdateAttributes();
            statManager.UpdateStatistics();
            Assert.AreNotEqual(0, statManager.BaseStatistics.Count);
            Assert.AreNotEqual(0, statManager.CurrentStatistics.Count);
        }

        [TestMethod]
        public void TestUpdateAttributes()
        {
            Unit A = new Unit("test_A", null, null, new BasicSword());
            Dictionary<AttributeEnum, int> baseAttributes = StatHelper.GetDefaultAttributes();
            Dictionary<StatisticsEnum, Func<Unit, int>> statisticsComputer = StatHelper.GetDefaultComputer();
            StatManager statManager = new StatManager(A, baseAttributes, statisticsComputer);
            A.StatManager = statManager;
            Assert.AreEqual(3, statManager.BaseAttributes.Count);
            Assert.AreEqual(0, statManager.CurrentAttributes.Count);
            statManager.UpdateAttributes();
            statManager.UpdateStatistics();
            Assert.AreEqual(3, statManager.BaseAttributes.Count);
            Assert.AreEqual(3, statManager.CurrentAttributes.Count);
        }
        
    }
}
