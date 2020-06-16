using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        private int FileCounter = 1;
        public List<Files> FilesOnDisc = new List<Files>();
        public DVD(string name, int storageCapacity, int capacityUsed, string diskType) : base(name, storageCapacity, capacityUsed, diskType)
        {
        }

        public void ReadData()
        {
            Console.WriteLine("Sorry, I'm afraid I can't do that.");
        }

        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }

        public void AddFile(string n, double s, string ft)
        {
                FilesOnDisc.Add(new Files(n, s, ft, FileCounter));
                FileCounter++;
        }

        public void DiskContents()
        {
            Console.WriteLine("Disc Contents\nFile Name  -  File Size");
            foreach (Files f in FilesOnDisc)
            {
                Console.WriteLine($"\n{f.Name}    -    {f.Size}    - of type {f.FileType}");
            }
        }
    }
}
