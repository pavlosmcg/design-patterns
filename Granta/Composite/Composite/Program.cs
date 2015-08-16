using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // pc case composite part
            Chassis chassis = new Chassis("PC Chassis", 5.0D, 55.00M, 40.00M);

            // add a mother board and graphics card
            MotherBoard board = new MotherBoard("ASUS P5QD", 150.0D, 99.99M, 85.50M);
            chassis.Add(board);
            Card card = new Card("Nvidia GTS 250", 100.0D, 79.99M, 69.99M);
            board.Add(card);

            // and a dvd drive
            OpticalDrive opticalDrive = new OpticalDrive("DVD RW", 10.0D, 21.50M, 15.99M);
            chassis.Add(opticalDrive);

            Console.WriteLine("The net price is: " + chassis.TotalCost().ToString());
            Console.WriteLine("The discount price is: " + chassis.TotalDiscountCost().ToString());
        }
    }
}
