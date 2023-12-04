using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    // The RemoteControl class represents a device that can be configured with different commands
    // and can execute or undo those commands.
    public class RemoteControl
    {
        // The current command associated with the remote control.
        private ICommand command;

        // Sets the command to be executed by the remote control.
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        // Executes the currently set command.
        public void DoAction()
        {
            command.Execute();
        }
        // Undoes the last executed command.
        public void UndoAction()
        {
            command.Undo();
        }
    }
}
