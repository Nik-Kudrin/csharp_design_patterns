using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Command.Devices;

namespace Patterns.Command
{
    internal class FanCommand : ICommand
    {
        private Fan fan;

        public FanCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.Low();
        }

        public void Undo()
        {
        }
    }
}