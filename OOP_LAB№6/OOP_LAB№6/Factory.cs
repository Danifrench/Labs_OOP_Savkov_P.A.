using System;

namespace OOP_LAB_6
{
    abstract class Factory
    {
        public abstract Good createGood(float cost, string id);
    }

    class GreensFactory : Factory
    {
        public override Good createGood(float cost, string id)
        {
            float weight = 0;
            int kkal = 0;
            return new Greens(cost, id, weight, kkal);
        }
    }

    class ClothesFactory : Factory
    {
        public override Good createGood(float cost, string id)
        {
            char size = 'S';
            string material = "cotton";

            return new Clothes(cost, id, size, material);
        }
    }

    class LaptopFactory : Factory
    {
        public override Good createGood(float cost, string id)
        {
            string procID = "7701";
            int ram = 4000;
            int hdd = 10000;

            return new Laptop(cost, id, procID, ram, hdd);
        }
    }
}

// ввод
// procID = 11001
// size 's'
// hdd = 404
// kkal = 110
//