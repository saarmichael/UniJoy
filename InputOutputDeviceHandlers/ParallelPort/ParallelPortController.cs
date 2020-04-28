using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace InputOutputDeviceHandlers.ParallelPort
{
    /*
     * https://www.codeproject.com/Tips/441815/Parallel-Port-Control-with-Csharp-NET-2-0
     */
    public class ParallelPortController
    {
        private int _address;

        public ParallelPortController(int address)
        {
            _address = address;
        }

        [DllImport("inpout32.dll", EntryPoint = "Out32")]
        public static extern void Output(int address, int value);

        public void Write(int value)
        {
            Output(_address, value);
        }
    }
}
