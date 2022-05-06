using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Join
    {
        //Coding Exercise 1
        /*
        Implement the GetHouseOwnersData method, which given a collection of people and 
        a collection of houses will return a collection of strings with the information 
        about house owners. The result should contain information about all people, 
        even if they don't own any houses. If a person owns more than one house, 
        it should be listed as many times in the result collection.

        For example, for the following input:
        
        People:
            *Id: 1, Name: John Smith
            *Id: 2, Name: Stephanie Green
            *Id: 3, Name: Martin Brown
        
        Houses:
            *OwnerId: 2, Address: "White Cottage, 18 Miners Overlook"
            *OwnerId: 3, Address: "Hilltop Mansion, 234 Maple Road"
            *OwnerId: 3, Address: "Beach Farm, 10 Seaside Street"
        
        The result shall be:
            *"Person: (Id:1), John Smith owns no house", 
            *"Person: (Id:2), Stephanie Green owns White Cottage, 18 Miners Overlook", 
            *"Person: (Id:3), Martin Brown owns Hilltop Mansion, 234 Maple Road", 
            *"Person: (Id:3), Martin Brown owns Beach Farm, 10 Seaside Street"
        
        Assume both input collections are non-empty.
         */
        public static IEnumerable<string> GetHouseOwnersData(
             IEnumerable<Person> people,
             IEnumerable<House> houses)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        /*
        Imagine you are working on a website of an online store selling groceries. 
        There is a need to provide functionality that will enable printing a summary 
        of all orders that have been made, including data of customers and the items 
        that have been bought.

        Let's say that this website uses a database with the following tables:        
        Customer (int id, string name)        
        Item (int id, string name)        
        Order (int customerId, int itemId, int count)
        
        Implement the GetOrdersData method, which given collections of customers, 
        items and orders, will produce a collection of strings containing the orders data.
        
        For example, for the following data:
        
        Customers
            *Id: 1, Name: John Smith
            *Id: 2, Name: Stephanie Green
            *Id: 3, Name: Marting Brown
        
        Items
            *Id: 1, Name: Tahini
            *Id: 2, Name: Maple Syrup
            *Id: 3, Name: Peanut Butter
        
        Orders
            *CustomerId: 1, ItemId: 2, Count: 2
            *CustomerId: 2, ItemId: 3, Count: 1
            *CustomerId: 3, ItemId: 1, Count: 4
        
        The result shall be the following collection of strings:
            *"Customer: John Smith, Item: Maple Syrup, Count: 2", 
            *"Customer: Stephanie Green, Item: Peanut Butter, Count: 1", 
            *"Customer: Martin Brown, Item: Tahini, Count: 4"
        
        Assume all input collections are non-empty.
         */
        public static IEnumerable<string> GetOrdersData(
            IEnumerable<Customer> customers,
            IEnumerable<Item> items,
            IEnumerable<Order> orders)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static Dictionary<House, Person> GetHousesData_Refactored(
            IEnumerable<Person> people,
            IEnumerable<House> houses)
        {
            //TODO your code goes here
            throw new NotImplementedException();
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
