using System;
using System.Collections.Generic;
using EvalRpgLib.Beings;
using EvalRpgLib.Exemples;
using EvalRpgLib.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvalRpgTests
{
    [TestClass]
    public class SkillTest
    {
        [TestMethod]
        public void TestSkillInitOK()
        {
            Unit A = new Unit("test_A");
            Skill sk = new Skill(A);

            Assert.IsTrue(A.Name == sk.Caster.Name);
        }

        [TestMethod]
        public void TestCastSkillOK()
        {
            // Bug corrigé dans la fonction UpdateStats: transformé CurrentStatistics.Clear() en CurrentStatistics = BaseStatistics
            Unit A = new Unit("test_A",null, null , new BasicSword());
            Unit B = new Unit("test_B", null, null, new BasicSword());
            A.StatManager = new StatManager(A, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            B.StatManager = new StatManager(B, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            A.StatManager.Update();
            B.StatManager.Update();
            A.Skills.Add(new HeavyStrike(A));
            Assert.IsTrue(A.Skills[0].Cast(B));
        }

        [TestMethod]
        public void TestComputePower() {
            Unit A = new Unit("test_A", null, null, new BasicSword());
            A.StatManager = new StatManager(A, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            A.StatManager.Update();
            A.Skills.Add(new HeavyStrike(A));
            Assert.AreEqual(10010, A.Skills[0].ComputePower());
        }

    }
}
