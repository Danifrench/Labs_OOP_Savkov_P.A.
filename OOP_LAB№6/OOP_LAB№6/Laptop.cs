using System;

namespace OOP_LAB_6
{
    class Laptop : Good
    {
        public Laptop(float cost, string name, string procID, int ram, int hdd)
            : base(cost, name)
        {
            _procID = procID;
            _ram = ram;
            _hdd = hdd;
        }

        private string _procID;
        private int _ram;
        private int _hdd;
    }
}
