using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    public interface ICommand
    {
        void Execute();
    }

    public enum Movement
    {
        Forward,
        Backward
    }
}
