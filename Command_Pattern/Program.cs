using Command_Pattern;

namespace Command_Pattern
{


    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Character class, representing the character to be controlled.
            Character character = new Character();

            // Create instances of different commands to perform specific actions.
            ICommand moveCommand = new MoveForwards(character);
            ICommand attackCommand = new AttackCommand(character);
            ICommand stopCommand = new StoppedMoving(character);

            // Create a RemoteControl instance to manage the execution of commands.
            RemoteControl remote = new RemoteControl();

            // Associate the MoveForwards command with the RemoteControl and execute it.
            remote.SetCommand(moveCommand);
            remote.DoAction();

            // Associate the AttackCommand with the RemoteControl and execute it.
            remote.SetCommand(attackCommand);
            remote.DoAction();

            // Undo the last executed command (AttackCommand) using the RemoteControl.
            remote.UndoAction();

            // Associate the StoppedMoving command with the RemoteControl and execute it.
            remote.SetCommand(stopCommand);
            remote.DoAction();
        }
    }
}