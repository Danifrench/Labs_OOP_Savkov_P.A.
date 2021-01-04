using System;

namespace OOP_LAB_6
{
    abstract class Factory
    {
        public abstract Good createGood(float cost, string name);
    }

    class GreensFactory : Factory
    {
        public override Good createGood(float cost, string name)
        {
            float weight = 0;
            int kkal = 0;
            return new Greens(cost, name, weight, kkal);
        }
    }

    class ClothesFactory : Factory
    {
        public override Good createGood(float cost, string name)
        {
            char size = 'S';
            string material = "cotton";

            return new Clothes(cost, name, size, material);
        }
    }

    class LaptopFactory : Factory
    {
        public override Good createGood(float cost, string name)
        {
            string procID = "7701";
            int ram = 4000;
            int hdd = 10000;

            return new Laptop(cost, name, procID, ram, hdd);
        }
    }
}

// ввод
// procID = 11001
// size 's'
// hdd = 404
// kkal = 110
//