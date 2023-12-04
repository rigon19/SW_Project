using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    /* I am creating an interface that forces command classes to implement the execute and undo
     funtions so the functions the command does should always be executable and undoable*/
    public interface ICommand
    {
        public void Execute();

        public void Undo();
    }
}
