using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputDeviceHandlers.UserInputs
{
    public interface IUserInputController
    {
        bool LoadButtonsMapping();

        bool IsStartButtonPressed();

        PressType SubjectChoice();

        void FlushBuffer();
    }
}
