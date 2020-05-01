using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputDeviceHandlers.UserInputs
{
    public class KeyBoardUserInputController : IUserInputController
    {
        byte[] _buf;
        Stream _inputStream;

        public KeyBoardUserInputController()
        {
            _buf = new byte[2048];
            _inputStream = Console.OpenStandardInput();

            _inputStream.BeginRead(_buf, 0, _buf.Length, null, null);
        }

        public bool IsStartButtonPressed()
        {

            int press =_inputStream.ReadByte();
            while (press != -1)
            {
                if(press == 's')
                {
                    return true;
                }

                press = _inputStream.ReadByte();
            }

            return false;
        }

        public byte SubjectChoice()
        {
            return 1;
            int byteRead = _inputStream.ReadByte();
            return (byte)
                (byteRead == 'a' ? 1 :
                (byteRead == 'b' ? 2 : 0));
        }

        public void FlushBuffer()
        {
            _inputStream.Flush();
        }

        public bool LoadButtonsMapping()
        {
            throw new NotImplementedException();
        }
    }
}
