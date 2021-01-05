using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_6
{
    public interface Builder
    {
        void BuildWeight(float weight);
        void BuildKkal(int kkal);
        void BuildSize(char size);
        void BuildMaterial(string material);
        void BuildProcessorID(string procID);
        void BuildRAM(int ram);
        void BuildHDD(int hdd);
    }

    public class GoodBuilder : Builder
    {
        private Good _good = new Good();

        // Новый экземпляр строителя должен содержать пустой объект продукта,
        // который используется в дальнейшей сборке.
        public GoodBuilder( )
        {
            this.Reset();
        }

        public void Reset()
        {
            this._good = new Good();
        }

        // Все этапы производства работают с одним и тем же экземпляром
        // продукта.
        public void BuildWeight(float weight)
        {
            this._good.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC1");
        }
    }
}
