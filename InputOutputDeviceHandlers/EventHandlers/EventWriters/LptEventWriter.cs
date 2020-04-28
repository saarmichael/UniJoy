using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniJoy.EventTypes;

namespace UniJoy.EventWriters
{
    public class LptEventWriter : IEventWriter<UnijoyEvent>
    {
        public void WriteEvent(UnijoyEvent eventName)
        {
            throw new NotImplementedException();
        }
    }
}
