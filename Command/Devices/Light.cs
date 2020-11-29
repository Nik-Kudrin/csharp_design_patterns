using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command.Devices
{
    internal class Light
    {
        private bool state;

        public void On()
        {
            state = true;
        }

        public void Off()
        {
            state = false;
        }
    }
}