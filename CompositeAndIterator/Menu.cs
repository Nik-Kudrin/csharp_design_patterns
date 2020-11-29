using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    internal class Menu : MenuComponent
    {
        private ArrayList menuComponents = new ArrayList();
        public String description = "Menu Description";

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int index)
        {
            return (MenuComponent) menuComponents[index];
        }

        public override string GetInfo()
        {
            var menuEnumerator = menuComponents.GetEnumerator();
            String info = "Menu: ( ";

            while (menuEnumerator.MoveNext())
            {
                info += (menuEnumerator.Current as MenuComponent).GetInfo();
            }

            info += " ); ";

            return info;
        }

        public override IEnumerator GetEnumerator()
        {
            return menuComponents.GetEnumerator();
        }
    }
}