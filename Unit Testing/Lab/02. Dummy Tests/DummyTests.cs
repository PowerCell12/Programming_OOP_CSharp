using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void Test_DummyTakingAttackAndHealthDropping()
        {

            Dummy dummy = new Dummy(10, 10);

            dummy.TakeAttack(5);

            Assert.AreEqual(5, dummy.Health, "Dummy wasn't attacked");
        }

        [Test]
        public void Test_AttackingDeadDummyTest(){

            Dummy dummy = new Dummy(0, 10);
            int attack  = 1;

            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(attack));

        }


        [Test]
        public void Test_DeadDummyReturnsExperience(){

            Dummy dummy = new Dummy(0, 10);

            Assert.AreEqual(10, dummy.GiveExperience());

        }

        [Test]
        public void Test_AliveDummyDoesntGiveEx(){

            Dummy dummy = new Dummy(1, 10);

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());

        }



    }
}