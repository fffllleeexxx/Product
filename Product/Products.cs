

namespace Test.Product
{
    public class Products
    {
        public int count;
        public int weight;
        public bool fragility;
        public int volume;
        public string name;

        public Products(string _name, int _count, int _weight, bool _fragility, int _volume)
        {
            count = _count;
            weight = _weight;
            fragility = _fragility;
            volume = _volume;
            name = _name;
        }

        public Products(string _name, int _count)
        {
            name = _name;
            count = _count;
        }

    }
}
