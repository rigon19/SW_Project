using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Command_Pattern
{
    public class Character
    {
        private string _currentAction;

        // The description of the action before the most recent action.
        private string _lastAction;

        // Expose currentAction through a property
        public string CurrentAction => _currentAction;
        public string LastAction => _lastAction;
        public  virtual void Move()
        {
            // Save the current action as the last action.
            _lastAction = _currentAction;

            // Set the current action to indicate moving forward.
            _currentAction = "Moved Forward";

            // Display a message indicating the character moved forward.
            Console.WriteLine("You moved forward");
        }

        // Performs an attack action, updating the action log.
        public virtual void Attack()
        {
            // Save the current action as the last action.
            _lastAction = _currentAction;

            // Set the current action to indicate an attack.
            _currentAction = "Attacked";

            // Display a message indicating the character attacked.
            Console.WriteLine("You attacked");
        }

        // Stops the character from moving, updating the action log.
        public virtual void Stop()
        {
            // Save the current action as the last action.
            _lastAction = _currentAction;

            // Set the current action to indicate stopping movement.
            _currentAction = "Stopped Moving";

            // Display a message indicating the character stopped moving.
            Console.WriteLine("You stopped moving");
        }

        // Undoes the last command/action, updating the action log.
        public virtual void Undo()
        {
            // Display a message indicating the undoing of the last command.
            Console.WriteLine("Undoing Last Command");

            // Restore the current action to the previous action.
            _currentAction = _lastAction;
        }
    }

}

