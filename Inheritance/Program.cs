using System;


//Name of the Folder
namespace Inheritance

{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent
            
            // Car car = new Car();
            // Bicycle bicycle = new Bicycle();
            // Boat boat = new Boat();

            // Console.WriteLine(car.speed);
            // Console.WriteLine(car.wheels);
            // car.go();

            // Console.WriteLine(bicycle.speed);
            // Console.WriteLine(bicycle.wheels);
            // bicycle.go();

            // Console.WriteLine(boat.speed);
            // Console.WriteLine(boat.wheels);
            // boat.go();

            Student student = new Student { name = "John", age = 20 };
            CollegeStudent collegeStudent = new CollegeStudent { name = "Jane", age = 18, major = "Computer Science" };
            HighSchoolStudent highSchoolStudent = new HighSchoolStudent { name = "Alex", age = 16, gradeLevel = "10th" };

            student.Study();
            collegeStudent.AttendClass();
            highSchoolStudent.AttendClass();

            

            
        }   
    }
    //class with inheritance and the purpose of inheritance 
    //is to reduce code duplication and to increase reusability of code.
    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }

    // a class without inheritance is a class that does not inherit any fields or methods from another class.
    // class Car
    // {
    //     public int speed = 0;
    //     public int wheels = 4;

    //     public void go()
    //     {
    //         Console.WriteLine("This car is moving!");
    //     }
    // }

    // class Bicycle
    // {
    //     public int speed = 0;
    //     public int wheels = 2;

    //     public void go()
    //     {
    //         Console.WriteLine("This bicycle is moving!");
    //     }
    // }

    // class Boat
    // {
    //     public int speed = 0;
    //     public int wheels = 0;

    //     public void go()
    //     {
    //         Console.WriteLine("This boat is moving!");
    //     }
    // }




    public class Person
    {
        public required string name { get; set; }
        public int age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {name} and I am {age} years old.");
        }
    }
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine($"{name} is studying.");
        }
        
        
    }
    public class CollegeStudent : Student
    {
        public required string major { get; set; }

        public void AttendClass()
        {
            Console.WriteLine($"{name} is attending a class in {major}.");
        }
    }
    public class HighSchoolStudent : Student
    {
        public required string gradeLevel { get; set; }

        public void AttendClass()
        {
            Console.WriteLine($"{name} is attending a class in grade {gradeLevel}.");
        }
    }
     
}

// public class CollegeStudent
// {
//     public required string name { get; set; }
//     public int age { get; set; }
//     public required string major { get; set; }

//     public void AttendClass()
//     {
//         Console.WriteLine($"{name} is attending a class in {major}.");
//     }
// }

// public class HighSchoolStudent
// {
//     public required string name { get; set; }
//     public int age { get; set; }
//     public required string gradeLevel { get; set; }

//     public void AttendClass()
//     {
//         Console.WriteLine($"{name} is attending a class in grade {gradeLevel}.");
//     }
// }