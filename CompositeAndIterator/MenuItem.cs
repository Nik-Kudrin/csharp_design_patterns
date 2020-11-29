using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    internal class MenuItem : MenuComponent
    {
        public bool vegetarian;
        public String description = "MenuItem Text";

        public MenuItem(bool isVegetarian)
        {
            vegetarian = isVegetarian;
        }

        public override bool IsVegetarian()
        {
            return vegetarian;
        }

        public override string GetInfo()
        {
            return "Menu Item: vegetarian - " + vegetarian + "; ";
        }

        public override IEnumerator GetEnumerator()
        {
            return new NullIterator();
        }
    }
}