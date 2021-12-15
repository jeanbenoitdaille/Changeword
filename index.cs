    using System;
     
    namespace Coding.Exercise
    {
        public struct Exercise
        {
            public void Main()
            {
                var p1 = new Person("John", 31);
                var p2 = p1;
                p2.Name = "Alice";
                p2.Name = 42;
     
                Console.WriteLine($"My name is {p1.Name} and i am {p1.Age} years old");
                Console.WriteLine($"My name is {p2.Name} and i am {p2.Age} years old");
            }
        }
        
        public struct Person
        {
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
     
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }