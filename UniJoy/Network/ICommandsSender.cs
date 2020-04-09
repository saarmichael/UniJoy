using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniJoy.Network
{
    public interface ICommandsSender
    {
        bool TrySendCommand(string commandName, string commandValue);

        bool TryStart();

        bool TryStop();
    }
}
