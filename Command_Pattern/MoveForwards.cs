using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class MoveForwards : ICommand
    {
        private Character character;

        public MoveForwards(Character character)
        {
            this.character = character;
        }
        public void Execute()
        {
            character.Move();
        }

        public void Undo()
        {
            character.Undo();
        }
    }
}
