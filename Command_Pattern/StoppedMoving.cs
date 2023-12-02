using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class StoppedMoving : ICommand
    {
        private Character character;

        public StoppedMoving(Character character)
        {
            this.character = character;
        }

        public void Execute()
        {
            character.Stop();
        }

        public void Undo()
        {
            character.Undo();
        }
    }
}
