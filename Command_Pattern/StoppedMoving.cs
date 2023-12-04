using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    // We are inherting the ICommand interface so we can implement the Execute and Undo methods
    public class StoppedMoving : ICommand
    {
        // Creating an instance of the Character class named 'character' that we are going to give
        //rights to use the Stopped Moving command
        private Character character;

        /* Giving the Stopped Moving method to the specified instance of the Character class
         we just created*/
        public StoppedMoving(Character character)
        {
            this.character = character;
        }
        /* The method executes the attack command*/
        public void Execute()
        {
            character.Stop();
        }

        // The method undoes the attack command 
        public void Undo()
        {
            character.Undo();
        }
    }
}
