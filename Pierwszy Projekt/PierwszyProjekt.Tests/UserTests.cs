using Pierwszy_Projekt;


namespace PierwszyProjekt.Tests
{
    public class Tests
    {
        [Test]
        public void ComperingIntType()
        {
            int number1 = (5);
            int number2 = (6);
            int result = number1 + number2;
            

            Assert.AreEqual(11, result);
        }


        [Test]
        public void ComperingStringType()
        {
            string name1 = "Krzysiu";
            string name2 = "Krzysiu";

            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void ComperingReferenceType()
        {
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");
        }
         private User GetUser(string firstName)
        {
            return new User (firstName);
        }
    }
}