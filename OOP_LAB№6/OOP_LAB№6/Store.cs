using System;
using System.Collections.Generic;

namespace OOP_LAB_6
{
    class Store
    {
        public Dictionary<int, HashSet<int>> _goodkkal;
        public Dictionary<float, HashSet<float>> _goodCost;
        public Dictionary<char, HashSet<char>> _goodSize;

        public void AddGood(float cost, string name, char wich)
        {
            Good newElement = null;

            switch(wich)
            {
                case 'l':
                    LaptopFactory NewLaptop = null;
                    newElement = NewLaptop.createGood(cost, name);
                    break;

                case 'c':
                    ClothesFactory NewClothes = null;
                    newElement = NewClothes.createGood(cost, name);
                    break;

                case 'g':
                    GreensFactory NewGreens = null;
                    newElement = NewGreens.createGood(cost, name);
                    break;
            }

            int id = newElement.GetID();

            _goodCost[newElement.GetCost()].Add(id);
            _goodID.Add(id, newElement);
        }

        public void DeleteGood(int id) 
        {
            // НЕ ПОНЯТНО КАК РЕШИТЬ ПРОБЛЕМУ
            // Удалить _goodID по id легко, но
            // Непонятно как очистить соответствующий элемент 
            // Т.К невозможно получить поле _kkal из Greens.h 
            // И поле _size из Clothes.h. Тут логично было бы испольщовать 
            // итератор, но у него достаточно мало методов. К тому же в классе
            // Good не вариант написать абстрактную функцию (например GetKkal), которая возвращала бы
            // значения kkal, например, т.к. прийдется эту функию описывать
            // в каждом дочернем классе класса Good, что явно бред, но решения
            // проблемы явного не вижу
        }

        public void Changes()
        {
            
        }

        public Dictionary<int, Good> _goodID;
    }
}
