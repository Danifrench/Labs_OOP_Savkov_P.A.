using System;
using System.Collections.Generic;

namespace OOP_LAB_6
{
    class Store
    {
        public Dictionary<int, HashSet<int>> _goodkkal;
        public Dictionary<int, HashSet<int>> _goodCost;
        public Dictionary<char, HashSet<int>> _goodSize;

        public Dictionary<int, Good> _goodID;
    }
}
