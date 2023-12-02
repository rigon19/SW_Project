using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class RemoteControl
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void DoAction()
        {
            command.Execute();
        }

        public void UndoAction()
        {
            command.Undo();
        }
    }
}
