using iCantina.models;

namespace iCantina.views
{
    public class VegetarianDish : CreateDish
    {
        public VegetarianDish()
        {
        }

        public VegetarianDish(string name) : base(name) { }

        public string Name { get; set; }
    }
}