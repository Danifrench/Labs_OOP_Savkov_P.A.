using System;

namespace OOP_LAB_6
{
    class Clothes : Good
    {
        public Clothes(float cost, string name, char size, string material)
            : base(cost, name)
        {
            _size = size;
            _material = material;
        }

        private char _size;
        private string _material; 
    }
}
