using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface = defines a "contract" that all the classes inheriting from should follow

            //             An interface declares "what a class should have"
            //             An inheriting class defines "how it should do it"

            //             benefits = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();
            
            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();

            // Using the printers
            InkjetPrinter inkjet = new InkjetPrinter();
            LaserPrinter laser = new LaserPrinter();

            PrinterService printerService = new PrinterService();
            printerService.StartPrinting(inkjet);  // Output: Printing using inkjet printer...
            printerService.StartPrinting(laser); // Output: Printing using laser printer...
            printerService.StartScanning(inkjet); // Output: Scanning using inkjet printer...
            printerService.StartScanning(laser); // Output: Scanning using laser printer...

            Console.ReadKey();
        }

        // interface = a contract that defines the signature of the functionality
        // when naming an interface, it is common to preface it with an "I"
        // we have two interfaces here, IPrey and IPredator that have a method each that the classes Rabbit, Hawk, and Fish implement 
        // why do we need interfaces?
        // interfaces allow us to define what methods a class should have, but not how they should do it
        // this allows us to define a "contract" that all classes inheriting from the interface should follow

        interface IPrey
        {
            void Flee();
        }
        interface IPredator
        {
            void Hunt();
        }

        // classes that inherit from the interfaces
        // the classes Rabbit, Hawk, and Fish all implement the methods defined in the interfaces
        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }
        }
        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food!");
            }
        }
        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish swims away!");
            }
            public void Hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish!");
            }
        } 
        public interface IPrinter
        {
            void Print();
            void Scan();
        
        }

        // Inkjet printer, which follows the IPrinter contract
        public class InkjetPrinter : IPrinter 
        {
            public void Print()
            {
                Console.WriteLine("Printing using inkjet printer...");
            }
            public void Scan()
            {
                Console.WriteLine("Scanning using inkjet printer...");
            }
        }

        // Laser printer, which also follows the IPrinter contract
        public class LaserPrinter : IPrinter
        {
            public void Print()
            {
                Console.WriteLine("Printing using laser printer...");
            }
            public void Scan()
            {
                Console.WriteLine("Scanning using laser printer...");
            }
        }

        // Using the printers
        public class PrinterService
        {
            public void StartPrinting(IPrinter printer)
            {
                printer.Print();
            }
            public void StartScanning(IPrinter printer)
            {
                printer.Scan();
            }
        }

        
    }  
}