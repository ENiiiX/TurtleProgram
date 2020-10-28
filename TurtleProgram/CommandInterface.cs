using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    interface CommandInterface
    {
        void setCommand(String command, params object[] list);
    }
}
