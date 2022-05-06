using NUnit.Framework;
using System.Collections.Generic;
using Contains = Exercises.Contains;
using Friend = Exercises.Contains.Friend;
using Person = Exercises.Contains.Person;

namespace ExercisesTests
{
    [TestFixture]
    public class Contains_Exercise2_Tests
    {
        [Test]
        public void FriendWith3Friends()
        {
            var friend = new Friend();
            var otherFriend = new Friend();
            var people = new List<Person>
            {
                new Person("John", new [] {friend}),
                new Person("Mary", new [] {friend, otherFriend}),
                new Person("Jack", new [] {friend, otherFriend}),
                new Person("Martin", new [] {otherFriend})
            };

            var result = Contains.CountFriendsOf(friend, people);
            Assert.AreEqual(result, 3, $"The test failed, because the count of " +
                $"fiends is 3, and te result of the CountFriendsOf method was {result}");
        }

        [Test]
        public void FriendWith1Friend()
        {
            var friend = new Friend();
            var otherFriend = new Friend();
            var people = new List<Person>
            {
                new Person("Mary", new [] {friend, otherFriend}),
                new Person("Martin", new [] {otherFriend})
            };

            var result = Contains.CountFriendsOf(friend, people);
            Assert.AreEqual(result, 1, $"The test failed, because the count of " +
                $"people is 1, and te result of the CountFriendsOf method was {result}");
        }
    }
}
