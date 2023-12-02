using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class AttackCommand : ICommand
    {
        private Character character;

        public AttackCommand(Character character)
        {
            this.character = character;
        }

        public void Execute()
        {
            character.Attack();
        }

        public void Undo()
        {
            character.Undo();
        }
    }
}
