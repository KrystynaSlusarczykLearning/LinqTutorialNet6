using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesSolutions
{
    public static class Join
    {
        //Coding Exercise 1
        public static IEnumerable<string> GetHouseOwnersData(
             IEnumerable<Person> people,
             IEnumerable<House> houses)
        {
            return people.GroupJoin(
                houses,
                person => person.Id,
                house => house.OwnerId,
                (person, personHouses) => new
                {
                    Owner = person,
                    Houses = personHouses
                })
                .SelectMany(ownerHouses => ownerHouses.Houses.DefaultIfEmpty(),
                (ownerHouses, singleHouse) => $"Person: {ownerHouses.Owner} " +
                $"owns {GetHouseNameOrDefault(singleHouse)}");
        }

        public static string GetHouseNameOrDefault(House house)
        {
            return house == null ? "no house" : house.Adderss;
        }

        //Coding Exercise 2
        public static IEnumerable<string> GetOrdersData(
            IEnumerable<Customer> customers,
            IEnumerable<Item> items,
            IEnumerable<Order> orders)
        {
            var orderCustomers = orders.Join(
                customers,
                order => order.CustomerId,
                customer => customer.Id,
                (order, customer) => new { order, customer });

            var orderCustomerItems = orderCustomers.Join(
                items,
                orderCustomer => orderCustomer.order.ItemId,
                item => item.Id,
                (orderCustomer, item) => new
                {
                    Order = orderCustomer.order,
                    Customer = orderCustomer.customer,
                    Item = item
                });

            return orderCustomerItems.Select(
                orderCustomerItem =>
                    $"Customer: {orderCustomerItem.Customer.Name}," +
                    $" Item: {orderCustomerItem.Item.Name}," +
                    $" Count: {orderCustomerItem.Order.Count}");
        }

        //Refactoring challenge
        public static Dictionary<House, Person> GetHousesData_Refactored(
            IEnumerable<Person> people,
            IEnumerable<House> houses)
        {
            return people.Join(
                houses,
                person => person.Id,
                house => house.OwnerId,
                (person, personHouse) => new
                {
                    Owner = person,
                    House = personHouse
                })
                .ToDictionary(
                ownerHouse => ownerHouse.House,
                ownerHouse => ownerHouse.Owner);
        }

        //do not modify this method
        public static Dictionary<House, Person> GetHousesData(
            IEnumerable<Person> people,
            IEnumerable<House> houses)
        {
            var result = new Dictionary<House, Person>();
            foreach (var house in houses)
            {
                foreach (var owner in people)
                {
                    if (owner.Id == house.OwnerId)
                    {
                        result[house] = owner;
                    }
                }
            }
            return result;
        }

        public class House
        {
            public int OwnerId { get; }
            public string Adderss { get; }

            public House(int ownerId, string adderss)
            {
                OwnerId = ownerId;
                Adderss = adderss;
            }

            public override string ToString()
            {
                return $"(OwnerId: {OwnerId}) {Adderss}";
            }
        }

        public class Person
        {
            public int Id { get; }
            public string Name { get; }

            public Person(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return $"(Id:{Id}), {Name}";
            }
        }

        public class Customer
        {
            public int Id { get; }
            public string Name { get; }

            public Customer(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}";
            }
        }

        public class Order
        {
            public int CustomerId { get; }
            public int ItemId { get; }
            public int Count { get; }

            public Order(int customerId, int itemId, int count)
            {
                CustomerId = customerId;
                ItemId = itemId;
                Count = count;
            }

            public override string ToString()
            {
                return $"CustomerId: {CustomerId}, ItemId: {ItemId}, Count: {Count}";
            }
        }

        public class Item
        {
            public int Id { get; }
            public string Name { get; }

            public Item(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}";
            }
        }
    }
}
