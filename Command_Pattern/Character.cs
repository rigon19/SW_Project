using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class Character
    {
        private string currentAction;
        private string lastAction;
        public void Move()
        {
            lastAction = currentAction;
            currentAction = "Moved Forward";
            Console.WriteLine("You moved Forward");
        }

        public void Attack()
        {
            lastAction = currentAction;
            currentAction = "Attacked";
            Console.WriteLine("You attacked");
        }

        public void Stop() {
            lastAction = currentAction;
            lastAction = "Stopped Moving";
            Console.WriteLine("You stopped moving");
        }

        public void Undo()
        {
            Console.WriteLine($"Undoing Last Command\nYou {lastAction}");
            currentAction = lastAction;
        }
    }
}
