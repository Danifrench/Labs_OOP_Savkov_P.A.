using System;
using System.Collections.Generic;

namespace OOP_LAB_6
{
    class Store
    {
        public Dictionary<int, Product> _goodID;

        public Dictionary<int, HashSet<int>> _goodkkal;
        public Dictionary<double, HashSet<int>> _goodweight;
        public Dictionary<int, HashSet<int>> _goodCost;
        public Dictionary<char, HashSet<int>> _goodSize;
        public Dictionary<string, HashSet<int>> _goodMaterial;
        public Dictionary<int, HashSet<int>> _goodRAM;

        public void AddGood(string fields)
        {
            
            Product newElement = null;

            Factory newFactoryProduct = null;
            newElement = newFactoryProduct.createGood(fields);

            string[] items = newElement.GetField();

            switch (newElement.GetType().ToString())
            {
                case "Greens":
                    // int kkal = Convert.ToInt32(items[0]);
                    // double weight = Convert.ToDouble(items[1]);

                    _goodkkal[Convert.ToInt32(items[0])].Add(newElement.GetID);
                    _goodweight[Convert.ToDouble(items[1])].Add(newElement.GetID);
                    break;

                case "Clothes":
                    // char size = Convert.ToChar(items[3]);
                    // string material = items[4];

                    _goodSize[Convert.ToChar(items[3])].Add(newElement.GetID);
                    _goodMaterial[items[4]].Add(newElement.GetID);
                    break;

                case "Laptop":
                    // int ram = Convert.ToInt32(items[4]);

                    _goodRAM[Convert.ToInt32(items[4])].Add(newElement.GetID);
                    break;
            }

            _goodCost[newElement.GetCost()].Add(newElement.GetID);
            _goodID.Add(newElement.GetID, newElement);
        }

        public void DeleteGood(int id) 
        {
            string[] items = _goodID[id].GetField();

            switch (items[0])
            {
                case "Greens":
                    _goodkkal[Convert.ToInt32(items[0])].Remove(id);
                    _goodweight[Convert.ToDouble(items[1])].Remove(id);
                    break;

                case "Clothes":
                    _goodSize[Convert.ToChar(items[3])].Remove(id);
                    _goodMaterial[items[4]].Remove(id);
                    break;

                case "Laptop":
                    _goodRAM[Convert.ToInt32(items[4])].Remove(id);
                    break;
            }

        } 
    }
}
