using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        void SpinDisc();
        void ReadData();
        void AddFile(string n, double s, string ft); 
    }
}
