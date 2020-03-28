using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputControllers
{
    public interface IUserInputController
    {
        bool IsStartButtonPressed();

        byte SubjectMovementChoice();

        void FlushBuffer();
    }
}
