using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public int RemainingCapacity { get; set; }
        public int CapacityUsed { get; set; }
        public string DiskType { get; set; }


        protected BaseDisc(string name, int storageCapacity, int capacityUsed, string diskType)
        {
            Name = name;
            DiskType = diskType;

            StorageCapacity = storageCapacity;
            CapacityUsed = CheckCapacity(capacityUsed);
            RemainingCapacity = SpaceLeft();
        }

        public int SpaceLeft()
        {
            return StorageCapacity - CapacityUsed;
        }

        public int CheckCapacity(int capacityUsed)
        {
            if (StorageCapacity < capacityUsed)
            {
                return StorageCapacity;
            }
            else
            {
                return capacityUsed;
            }
        }

        public string DiscInfo()
        {
            string output = $"Disk Name: {Name}\nMax Capacity: {StorageCapacity}\nSpace Used: {CapacityUsed}\nAvailable Storage: {RemainingCapacity}\n";
            return output;
        }

        public string WriteData(int size)
        {
            if (size > RemainingCapacity)
            {
                return "Not enough space!";
            }

            CapacityUsed += size;
            RemainingCapacity -= size;

            return $"Data written to disc. Remaining space = {RemainingCapacity}";
        }
    }
}
