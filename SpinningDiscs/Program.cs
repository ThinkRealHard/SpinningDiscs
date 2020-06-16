using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            DVD dvd = new DVD("DVD example", 4700, 1450, "DVD-R");
            CD cd = new CD("CD example", 700, 350, "CD-RW");

            // TODO: Call each CD and DVD method to verify that they work as expected.

            dvd.SpinDisc();
            cd.SpinDisc();

            Console.WriteLine("\n");

            dvd.ReadData();
            cd.ReadData();

            Console.WriteLine("\n");

            Console.WriteLine(dvd.DiscInfo());
            Console.WriteLine(cd.DiscInfo());

            Console.WriteLine(dvd.WriteData(8000));
            Console.WriteLine(cd.WriteData(300));

            Console.WriteLine(dvd.DiscInfo());
            Console.WriteLine(cd.DiscInfo());

            dvd.AddFile("Funonabun", 20.00, ".jpg");
            cd.AddFile("Wannabe", 400.34, ".mp3");
            dvd.DiskContents();
            cd.DiskContents();
        }
    }
}
