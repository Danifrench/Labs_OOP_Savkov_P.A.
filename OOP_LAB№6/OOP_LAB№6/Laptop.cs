using System;

namespace OOP_LAB_6
{
    class Laptop : Good
    {
        public Laptop(float cost, string id, string procID, int ram, int hdd)
            : base(cost, id)
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
