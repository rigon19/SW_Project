using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    // We are inherting the ICommand interface so we can implement the Execute and Undo methods
    public class AttackCommand : ICommand
    {
        // Creating an instance of the Character class named 'character' that we are going to give
        //rights to use the Attack command
        private Character character;

        /* Giving the AttackCommand method to the specified instance of the Character class
         we just created*/
        public AttackCommand(Character character)
        {
            this.character = character;
        }
        
        /* The method executes the attack command*/
        public void Execute()
        {
            character.Attack();
        }
        // The method undoes the attack command 
        public void Undo()
        {
            character.Undo();
        }
    }
}
