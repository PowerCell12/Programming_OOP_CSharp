namespace DatabaseExtended.Tests
{
    using NUnit.Framework;
    using ExtendedDatabase;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {



        // [Test]
        // public void  Test_AddIfAlready16Elements(){

        //     Database database = new Database(new int[16] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12 ,13 ,14 ,15 ,16});

        //     Assert.Throws<InvalidOperationException>(() => database.Add(17));


        // }  


        // [Test]
        // public void Test_RemoveIfEmptyDatabase(){

        //     Database database = new Database(new int[16] {0 ,0 ,0,0,0,0,0,0,0,0,0,0,0,0,0,0});

        //     for (int i = 0; i < 16; i++){

        //         database.Remove();
        //     }


        //     Assert.Throws<InvalidCastException>(() => database.Remove());


        // }


        // [Test]
        // public void Test_FetchReturnsWithoutProblem(){

        //     Database database = new Database(new int[16] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 ,1 ,1, 1, 1});

        //     int[] final = new int[16] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 ,1 ,1, 1, 1};
        //     Assert.AreEqual(final, database.Fetch());


        // }
        

        [Test]
        public void Test_Remove(){

            Person person = new Person(10, "PDW");
            Database database = new Database(new Person[1] {person});

            database.Remove();

            Assert.AreEqual(database.Count, 0);

        }


// from here
        [Test]
        public void Test_AddIfUserAlreadyIn(){

            Person person = new Person(15, "PCG");
            Database database = new Database(new Person[1] {person});
            Person person1 = new Person(10, "PCG");
            database.Remove();

            Assert.Throws<InvalidOperationException>(() => database.Add(person1));

        }


        [Test]
        public void Test_AddIfIdAlreadyIn(){

            Person person = new Person(15, "First");
            Database database = new Database(new Person[1] {person});
            database.Remove();

            Person person1 = new Person(15, "Second");

            Assert.Throws<InvalidOperationException>(() => database.Add(person1));
        }

        [Test]
        public void Test_AddIfMax(){

            Person person = new Person(15, "First");
            Database database = new Database(new Person[1] {person});

            Person person1 = new Person(158, "Second");

            Assert.Throws<InvalidOperationException>(() => database.Add(person1));
        }

        [Test]
        public void Test_RemoveIfCountIsZero(){

            Person person = new Person(15, "First");
            Database database = new Database(new Person[1] {person});

            //count shoud become zero
            database.Remove();

            Assert.Throws<InvalidOperationException>(() => database.Remove());

        }


        [Test]
        public void Test_FindByUsernameIsInIt(){

            Person person = new Person(20, "PCG");
            Database database = new Database(new Person[1] {person});

            Assert.Throws<InvalidOperationException>(() => database.FindByUsername("PCG1"));


        }


        [Test]
        public void Test_FindByUsernameUserIsNull(){

            Person person = new Person(16, "Second");
            Database database = new Database(new Person[1] {person});

            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(null));

        }

        [Test]
        public void Test_FindByIdNoUserById(){

            Person person = new Person(16, "Second");
            Database database = new Database(new Person[1] {person});


            Assert.Throws<InvalidOperationException>(() => database.FindById(17));

        }

        [Test]
        public void Test_FindByIdNegativeid(){

            Person person = new Person(13, "Third");
            Database database = new Database(new Person[1] {person});

            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(-1));

        }

    }
}