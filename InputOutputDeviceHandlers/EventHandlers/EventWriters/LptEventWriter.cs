using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InputOutputDeviceHandlers.EventHandlers.EventTypes;
using InputOutputDeviceHandlers.ParallelPort;

namespace InputOutputDeviceHandlers.EventHandlers.EventWriters
{
    public class LptEventWriter : IEventWriter<UnijoyEvent>
    {
        private ParallelPortController _parallelPortController;

        public LptEventWriter(int address)
        {
            _parallelPortController = new ParallelPortController(address);
        }

        public void WriteEvent(UnijoyEvent eventName)
        {
            _parallelPortController.Write((int)eventName);
        }
    }
}
