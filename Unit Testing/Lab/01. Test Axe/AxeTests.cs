using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void Test_WhenAttackingIfItLosesDurability()
        {

            Axe axe = new Axe(5, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints, "Axe durabillity didn't change");

        }


        [Test]
        public void Test_WhenAttackingWithABrokenWeapon(){

            Axe axe = new Axe(5, 0);
            Dummy dummy = new Dummy(10, 10);
            
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}