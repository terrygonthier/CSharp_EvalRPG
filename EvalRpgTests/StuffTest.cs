using System;
using EvalRpgLib.Beings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvalRpgTests
{
    [TestClass]
    public class StuffTest
    {
        [TestMethod]
        public void TestConstructorOK(){
            Stuff stuff = new Stuff("Awesome blade");
            Assert.AreEqual("Awesome blade", stuff.Name);
        }

        [TestMethod]
        public void TestAddAttributes() {
            Stuff stuff = new Stuff("Awesome blade");
            AttributEffect attributEffect = new AttributEffect();
            attributEffect.Attribute = AttributeEnum.Intelligence;
            attributEffect.Value = 2;
            stuff.AddAttributEffects(attributEffect);
            Assert.AreEqual(attributEffect.Attribute, stuff.StatusEffects[0].Attribute);
            Assert.AreEqual(attributEffect.Value, stuff.StatusEffects[0].Value);
        }
    }
}
