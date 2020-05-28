using InputOutputDeviceHandlers.UserInputs.Cedrus;
using System;

class TestClass
{
    static void Main(string[] args)
    {
        CedrusResponseBox crb = new CedrusResponseBox();

        crb.IsStartButtonPressed();

        Console.ReadLine(); ;
    }
}