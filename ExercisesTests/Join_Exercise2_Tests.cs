using NUnit.Framework;
using static ExercisesTests.Utilities.TestUtilities;
using Item = Exercises.Join.Item;
using Customer = Exercises.Join.Customer;
using Order = Exercises.Join.Order;
using Exercises;

namespace ExercisesTests
{
    [TestFixture]
    public class Join_Exercise2_Tests
    {
        [Test]
        public void GetOrdersDataShallWorkCorrectly_WhenOneCustomerHasMoreThanOneOrders()
        {
            var items = new[]
            {
              new Item(1, "Tahini"),
              new Item(2, "Maple Syrup"),
              new Item(3, "Peanut Butter")
            };

            var customers = new[]
            {
              new Customer(1, "John Smith"),
              new Customer(2, "Stephanie Green"),
              new Customer(3, "Martin Brown")
            };

            var orders = new[]
            {
                new Order(1, 1, 3),
                new Order(1, 2, 1),
                new Order(2, 3, 2),
                new Order(3, 2, 4)
            };

            var result = Join.GetOrdersData(customers, items, orders);
            var expectedResult = new[]
            {
                "Customer: John Smith, Item: Tahini, Count: 3",
                "Customer: John Smith, Item: Maple Syrup, Count: 1",
                "Customer: Stephanie Green, Item: Peanut Butter, Count: 2",
                "Customer: Martin Brown, Item: Maple Syrup, Count: 4"
            };

            CollectionAssert.AreEquivalent(expectedResult, result, $"For ITEMS {EnumerableToString(items)}, CUSTOMERS  {EnumerableToString(customers)} and ORDERS : {EnumerableToString(orders)} the RESULT shall be {EnumerableToString(expectedResult)}, BUT IT WAS {EnumerableToString(result)}");
        }

        [Test]
        public void GetOrdersDataShallWorkCorrectly()
        {
            var items = new[]
            {
              new Item(1, "Tahini"),
              new Item(2, "Maple Syrup"),
              new Item(3, "Peanut Butter")
            };

            var customers = new[]
            {
              new Customer(1, "John Smith"),
              new Customer(2, "Stephanie Green"),
              new Customer(3, "Martin Brown")
            };

            var orders = new[]
            {
                new Order(1, 2, 2),
                new Order(2, 3, 1),
                new Order(3, 1, 4)
            };

            var result = Join.GetOrdersData(customers, items, orders);
            var expectedResult = new[]
            {
                "Customer: John Smith, Item: Maple Syrup, Count: 2",
                "Customer: Stephanie Green, Item: Peanut Butter, Count: 1",
                "Customer: Martin Brown, Item: Tahini, Count: 4"
            };

            CollectionAssert.AreEquivalent(expectedResult, result, $"For ITEMS {EnumerableToString(items)}, CUSTOMERS  {EnumerableToString(customers)} and ORDERS : {EnumerableToString(orders)} the RESULT shall be {EnumerableToString(expectedResult)}, BUT IT WAS {EnumerableToString(result)}");
        }
    }
}
