using System;


// namespace is the name of the project
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args) {

            // polymorphism = Greek word that means to "have many forms"
            //                Objects can be identified by more than one type
            //                Ex. A Dog is also: Canine, Animal, Organism

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = {car, bicycle, boat};

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
           
            Console.ReadKey();

            // polymorphism with student example
            Student student = new Student();
            Undergraduate undergraduate = new Undergraduate();
            Graduate graduate = new Graduate();

            Student[] students = {student, undergraduate, graduate};

            foreach (Student s in students)
            {
                s.Study();
            }
        }
    }

    // Base class
    // what is the purpose of a base class?
    // to provide a common interface for all derived classes
    // ex. Vehicle is the base class for Car, Bicycle, Boat
    // in english, all vehicles go but they all go differently
    class Vehicle
    {
        // virtual keyword allows the method to be overridden in derived classes
        // this is called a virtual method
        public virtual void Go()
        {

        }
    }

    // Derived classes
    // what is the purpose of a derived class?
    // to provide specific implementations for the base class
    // ex. Car, Bicycle, Boat are all vehicles but they all move differently
    class Car: Vehicle
    {

        // override keyword is used to provide a specific implementation for the base class
        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }
    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }
    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }


    class Student
    {
        public virtual void Study()
        {
            Console.WriteLine("The student is studying.");
        }
    }

    class Undergraduate : Student
    {
        public override void Study()
        {
            Console.WriteLine("The undergraduate student is studying for their bachelor's degree.");
        }
    }

    class Graduate : Student
    {
        public override void Study()
        {
            Console.WriteLine("The graduate student is studying for their master's degree.");
        }
    }
    
}