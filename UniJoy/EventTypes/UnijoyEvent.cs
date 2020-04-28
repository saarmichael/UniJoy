using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputDeviceHandlers.EventHandlers.EventTypes
{
    public enum UnijoyEvent
    {
       StimulusStart,
       UserPressStart,
       UserPressChoice,
       StimulusEnd,
       AudioWaitForStart,
       MoogStartMovingBackward,
       MoogEndMovingBackward
    }
}
