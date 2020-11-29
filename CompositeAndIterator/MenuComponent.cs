using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    internal abstract class MenuComponent : IEnumerable
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int index)
        {
            throw new NotSupportedException();
        }

        public virtual bool IsVegetarian()
        {
            throw new NotSupportedException();
        }

        public virtual String GetInfo()
        {
            throw new NotSupportedException();
        }

        public abstract IEnumerator GetEnumerator();
    }
}