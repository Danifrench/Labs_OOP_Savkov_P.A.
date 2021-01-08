using System;
using System.Collections.Generic;

namespace OOP_LAB_6
{
    class Store
    {
        public Dictionary<int, Product> _productID;

        public Dictionary<int, HashSet<int>> _productkkal;
        public Dictionary<double, HashSet<int>> _productweight;
        public Dictionary<int, HashSet<int>> _productCost;
        public Dictionary<char, HashSet<int>> _productSize;
        public Dictionary<string, HashSet<int>> _productMaterial;
        public Dictionary<int, HashSet<int>> _productRAM;

        public void AddProduct(string fields)
        {
            
            Product newElement = null;

            Factory newFactoryProduct = null;
            newElement = newFactoryProduct.createProduct(fields);

            string[] items = newElement.GetField();

            switch (newElement.GetType().ToString())
            {
                case "Greens":
                    // int kkal = Convert.ToInt32(items[0]);
                    // double weight = Convert.ToDouble(items[1]);

                    _productkkal[Convert.ToInt32(items[0])].Add(newElement.GetID);
                    _productweight[Convert.ToDouble(items[1])].Add(newElement.GetID);
                    break;

                case "Clothes":
                    // char size = Convert.ToChar(items[3]);
                    // string material = items[4];

                    _productSize[Convert.ToChar(items[3])].Add(newElement.GetID);
                    _productMaterial[items[4]].Add(newElement.GetID);
                    break;

                case "Laptop":
                    // int ram = Convert.ToInt32(items[4]);

                    _productRAM[Convert.ToInt32(items[4])].Add(newElement.GetID);
                    break;
            }

            _productCost[newElement.GetCost()].Add(newElement.GetID);
            _productID.Add(newElement.GetID, newElement);
        }

        public void DeleteProduct(int id) 
        {
            string[] items = _productID[id].GetField();

            switch (items[0])
            {
                case "Greens":
                    _productkkal[Convert.ToInt32(items[0])].Remove(id);
                    _productweight[Convert.ToDouble(items[1])].Remove(id);
                    break;

                case "Clothes":
                    _productSize[Convert.ToChar(items[3])].Remove(id);
                    _productMaterial[items[4]].Remove(id);
                    break;

                case "Laptop":
                    _productRAM[Convert.ToInt32(items[4])].Remove(id);
                    break;
            }

        } 
    }
}
