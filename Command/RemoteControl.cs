using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    internal class RemoteControl
    {
        private ICommand slot = new NoCommand();

        public void SetCommand(ICommand command)
        {
            slot = command;
        }

        public void Perform()
        {
            slot.Execute();
        }
    }
}