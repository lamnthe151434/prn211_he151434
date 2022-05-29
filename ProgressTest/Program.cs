using System;
using System.Collections.Generic;

namespace ProgressTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();
                int option = getInt("your option", 0, 2);
                switch (option)
                {
                    case 0:
                        return;
                    case 1:
                        DemoGeneric();
                        break;
                    case 2:
                        DemoCollection();
                        break;
                }
            }

        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Demo Generic");
            Console.WriteLine("2. Demo Collection");
            Console.WriteLine("0. Exit");
        }

        public static int getInt(string message, int min, int max)
        {
            Console.Write($"Enter {message}: ");
            while (true)
            {
                try
                {

                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x < min || x > max)
                    {
                        throw new Exception($"You must enter a number between {min} - {max}");
                    }
                    return x;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered wrong format!");
                    Console.Write($"Please enter again {message}: ");
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void DemoGeneric()
        {
            Console.WriteLine();


            // Demo Generic
            DemoGenericClass();

            // Demo Contraint
            //DemoContraint();

            // Demo Generic Interface
            DemoGenericInterface();

            Console.WriteLine();
        }

        public static void DemoCollection()
        {
            Console.WriteLine();


            // Demo List
            DemoList();

            // Demo SortedSet
            DemoSortedSet();

            // Demo Enumerable
            DemoEnumerable();

            // Demo LinkedList
            DemoLinkedList();

            // Demo Dictionary
            DemoDictionary();

            // Demo Sorted Dictionary
            DemoSortedDictionary();

            // Demo Queue (FIFO)
            DemoQueue();

            // Demo Stack (LIFO)
            DemoStack();

            Console.WriteLine();

        }

        public static void DemoStack()
        {
            Console.WriteLine("\n8. Demo Stack");

            Stack<int> myStack = new();

            for (int i = 0; i < 10; i++)
            {
                myStack.Push(i);
            }

            Console.WriteLine("Stack after push 0-9 numbers: ");
            foreach (var item in myStack)
            {
                Console.Write($"{item,2}");
            }
            Console.WriteLine();

            myStack.Pop();
            myStack.Pop();
            Console.WriteLine("Stack after pop 2 times: ");
            foreach (var item in myStack)
            {
                Console.Write($"{item,2}");
            }
            Console.WriteLine();


        }

        public static void DemoQueue()
        {
            Console.WriteLine("\n7. Demo Queue");

            Queue<int> myQueue = new();

            for (int i = 0; i < 10; i++)
            {
                myQueue.Enqueue(i);
            }

            Console.WriteLine("Queue after enqueue 0-9 numbers: ");
            foreach (var item in myQueue)
            {
                Console.Write($"{item, 2}");
            }
            Console.WriteLine();

            myQueue.Dequeue();
            myQueue.Dequeue();

            Console.WriteLine("Queue after dequeue 2 times: ");
            foreach (var item in myQueue)
            {
                Console.Write($"{item,2}");
            }
            Console.WriteLine();


        }

        public static void DemoSortedDictionary()
        {
            Console.WriteLine("\n6. Demo Sorted Dictionary");
            SortedDictionary<int, string> people = new();

            people.Add(5, "Lam");
            //people.Add(1, "Thanh");
            people.Add(4, "Duc");
            people.Add(3, "Canh");
            people.Add(2, "Phi");
            people.Add(1, "Hung");

            Console.WriteLine("People in Sorted Dictionary: ");

            foreach (var person in people)
            {
                Console.WriteLine($"Id: {person.Key}, Name: {person.Value}");
            }
        }

        public static void DemoDictionary()
        {
            Console.WriteLine("\n5. Demo Dictionary");

            Dictionary<int, string> people = new Dictionary<int, string>();

            people.Add(5, "Lam");
            //people.Add(1, "Thanh");
            people.Add(4, "Duc");
            people.Add(3, "Canh");
            people.Add(2, "Phi");
            people.Add(1, "Hung");

            Console.WriteLine("People in Dictionary: ");
            foreach (var person in people)
            {
                Console.WriteLine($"Id: {person.Key}, Name: {person.Value}");
            }
        }

        public static void DemoLinkedList()
        {
            Console.WriteLine("\n4. Demo LinkedList");
            List<int> list = new();
            LinkedList<int> linkedlist = new();

            var watch = new System.Diagnostics.Stopwatch();

            // Execution time when adding a number to list
            watch.Start();
            for (int i = 0; i < Math.Pow(10, 6); i++)
            {
                list.Add(i);
            }
            watch.Stop();

            long execuationTime = watch.ElapsedMilliseconds;
            Console.WriteLine($"Adding {Math.Pow(10, 6)} numbers to list spent {execuationTime} ms");

            // Execution time when adding a number to linkedlist
            watch.Start();
            for (int i = 1; i <= Math.Pow(10, 6); i++)
            {
                linkedlist.AddLast(i);
            }
            watch.Stop();

            execuationTime = watch.ElapsedMilliseconds;
            Console.WriteLine($"Adding {Math.Pow(10, 6)} numbers to linkedlist spent {execuationTime} ms");


            watch.Start();
            for (int i = Convert.ToInt32(Math.Pow(10, 3)); i >= 10; i--)
            {
                list.Remove(i);
            }
            watch.Stop();
            Console.WriteLine($"Removing {Math.Pow(10, 3) - 9} numbers in list spent {execuationTime} ms");

            watch.Start();
            for (int i = Convert.ToInt32(Math.Pow(10, 3)); i >= 10; i--)
            {
                linkedlist.Remove(i);
            }
            watch.Stop();
            Console.WriteLine($"Removing {Math.Pow(10, 3) - 9} numbers in linkedlist spent {execuationTime} ms");

        }

        public static void DemoEnumerable()
        {
            Console.WriteLine("\n3. Demo Enumerable");

            MyCollectionClass<Person> collection = new();

            Person p1 = new Person() { Id = 5, Name = "Hau", Age = 21, Address = "Hai Duong" };
            Person p2 = new Person() { Id = 6, Name = "Phi", Age = 22, Address = "Ha Noi" };
            Person p3 = new Person() { Id = 7, Name = "Tung", Age = 19, Address = "Thai Binh" };
            Person p4 = new Person() { Id = 8, Name = "Duc", Age = 18, Address = "Nghe An" };

            collection.AddItem(p1, p2, p3, p4);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static void DemoSortedSet()
        {
            Console.WriteLine("\n2. Demo Sorted Set");


            Random random = new();
            SortedSet<int> sortedNumbers = new();


            // Before in sorted set
            Console.WriteLine("Before in sorted set: ");

            // Add random number to sorted set
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(100);
                sortedNumbers.Add(randomNumber);
                Console.Write($"{randomNumber,3}");
            }

            // After in sorted set
            Console.WriteLine("\nAfter in sorted set: ");

            foreach (int number in sortedNumbers)
            {
                Console.Write($"{number,3}");
            }
        }

        public static void DemoList()
        {
            Console.WriteLine("\n1. Demo List");

            List<Person> people = new();
            people.Add(new Person() { Id = 1, Name = "Lam", Age = 21, Address = "Hai Duong" });
            people.Add(new Person() { Id = 2, Name = "Thanh", Age = 22, Address = "Ha Noi" });
            people.Add(new Person() { Id = 3, Name = "Canh", Age = 19, Address = "Thai Binh" });
            people.Add(new Person() { Id = 4, Name = "Duc", Age = 18, Address = "Nghe An" });

            int numberOfPeople = people.Count;
            Console.WriteLine($"Number of people: {numberOfPeople}");
            Console.WriteLine("People information: ");
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }

        public static void DemoGenericInterface()
        {
            Console.WriteLine("\n3. Demo Generic Interface");
            MyFirstClass first = new();
            dynamic result = first.Add(5, 10);
            Console.WriteLine($"Result 1(int type): {result}");

            MySecondClass second = new();
            result = second.Add(5.5, 10.5);
            Console.WriteLine($"Result 2(double type): {result}");



        }

        public static void DemoContraint()
        {
            Console.WriteLine("\n3. Demo Contraint");
            //PersonList<string> stringPersonList = new();
            PersonList<Person> listPerson = new();
            Person person1 = new Person() { Id = 2, Name = "Thanh", Age = 12, Address = "Ha Noi" };
            Person person2 = new Person() { Id = 3, Name = "Lam", Age = 13, Address = "Hai Duong" };
            Person person3 = new Person() { Id = 4, Name = "Duc", Age = 14, Address = "Thai Binh" };

            listPerson.Insert(person1);
            listPerson.Insert(person2);
            listPerson.Insert(person3);

            listPerson.Display();
        }



        public static void DemoGenericClass()
        {
            Console.WriteLine("1. Demo Generic Class");

            // Instance of string type 
            MyClass<string> name = new();
            name.Value = "Nguyen Thanh Lam";
            Console.WriteLine(name);

            // Instance of float type
            MyClass<float> version = new();
            version.Value = 3.3f;
            Console.WriteLine(version);

            // Instance of dynamic type
            dynamic computer = new { ComputerName = "Dell", YearOfManufacture = "2020", Warranty = "1 year" };
            MyClass<dynamic> computerInfo = new();
            computerInfo.Value = computer;
            Console.WriteLine(computerInfo);

            // Instance of user-defined type
            Person person = new Person() { Id = 1, Name = "Lam", Age = 21, Address = "Hai Duong" };
            MyClass<Person> myInfo = new();
            myInfo.Value = person;
            Console.WriteLine(myInfo);

            Console.WriteLine("\n2. Demo Generic Method");

            // Instance of string type 
            name.Display<string, string>("My Name", "Lam");

            // Instance of float type
            version.Display<string, float>("My Version", 3.3f);

            // Instance of dynamic type
            computerInfo.Display<string, dynamic>("My Computer Info", computer);

            // Instance of user-defined type
            myInfo.Display<string, Person>("My Info", person);

        }


    }
}
