using System;

namespace OOP_LAB_6
{
    class Greens : Good
    {
        public Greens(float cost, string name, float weight, int kkal)
            : base(cost, name)
        {
            _weight = weight;
            _kkal = kkal;
        }

        private float _weight;
        private int _kkal;
    }
}
