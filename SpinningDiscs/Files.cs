using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public class Files
    {
        public string Name { get; set; }
        public double Size { get; set; }
        public string FileType { get; set; }
        private int ID { get; set; }

        public Files(string n, double s, string ft, int id)
        {
            Name = n;
            Size = s;
            FileType = ft;
            ID = id;
        }
    }
}
