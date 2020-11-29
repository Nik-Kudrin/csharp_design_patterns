using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    internal class NullIterator : IEnumerator
    {
        object IEnumerator.Current
        {
            get { return null; }
        }

        public bool MoveNext()
        {
            return false;
        }

        void IEnumerator.Reset()
        {
        }

        public void Dispose()
        {
        }
    }
}