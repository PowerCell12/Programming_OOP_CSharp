namespace Database.Tests
{
    using System;
    using NUnit.Framework;
    using NUnit.Framework.Constraints;

    [TestFixture]
    public class DatabaseTests
    {

        [Test]
        public void  Test_AddIfAlready16Elements(){

            Database database = new Database(new int[16] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12 ,13 ,14 ,15 ,16});

            Assert.Throws<InvalidOperationException>(() => database.Add(17));


        }  


        [Test]
        public void Test_RemoveIfEmptyDatabase(){

            Database database = new Database(new int[16] {0 ,0 ,0,0,0,0,0,0,0,0,0,0,0,0,0,0});

            for (int i = 0; i < 16; i++){

                database.Remove();
            }


            Assert.Throws<InvalidOperationException>(() => database.Remove());


        }


        [Test]
        public void Test_FetchReturnsWithoutProblem(){

            Database database = new Database(new int[16] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 ,1 ,1, 1, 1});

            int[] final = new int[16] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 ,1 ,1, 1, 1};
            Assert.AreEqual(final, database.Fetch());


        }
        

        [Test]
        public void Test_Remove(){

            Database database = new Database(new int[16] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 ,1 ,1, 1, 1});

            database.Remove();

            Assert.AreEqual(database.Count, 15);

        }


    }
}
