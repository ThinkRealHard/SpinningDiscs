using System;
using System.IO;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        private int FileCounter = 1;
        public List<Files> FilesOnDisc = new List<Files>();
        public CD(string name, int storageCapacity, int capacityUsed, string diskType) : base(name, storageCapacity, capacityUsed, diskType)
        {
        }

        public void ReadData()
        {
            Console.WriteLine("Would you like to play a game ?");
        }

        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
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
