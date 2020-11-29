using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.BehaviorPattern.Duck;

namespace Patterns.Adapter
{
    internal class TurkeyToDuckAdapter : Duck
    {
        private ITurkey turkey;

        public TurkeyToDuckAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public override void PerformFly()
        {
            turkey.ShortFly();
        }

        public override void PerformQuack()
        {
            turkey.Gobble();
        }
    }
}