using System;

namespace OOP_LAB_6
{
    class Greens : Good
    {
        public Greens(float cost, string id, float weight, int kkal)
            : base(cost, id)
        {
            _weight = weight;
            _kkal = kkal;
        }

        private float _weight;
        private int _kkal;
    }
}
