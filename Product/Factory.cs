using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Product
{
    public static class Factory
    {
        public static Products CreateProduct(string _name, int _count, int _weight, bool _fragility, int _volume)
        {
            return new Products(_name, _count, _weight, _fragility, _volume);
        }

        public static Food CreateFood(string _name, int _count, int _weight, bool _fragility, int _volume)
        {
            return new Food(_name, _count, _weight, _fragility, _volume);
        }

        public static Clothes CreateClothes(string _name, int _count)
        {
            return new Clothes(_name, _count);
        }
    }
}
