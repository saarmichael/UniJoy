using System;
using System.Collections.Generic;
using System.Text;

namespace UnijoyData.Shared.Commands
{
    public static class UnityEngineCommands
    {
        public static char CommandKeyValueSeperator = '?';

        public static char CommandsDelimiter = '#';

        public static string VisualOperationCommand = nameof(VisualOperationCommand);

        public static string ReadTrialData = "ReadTrialData";
    }

    public static class VisualOperationCommand
    {
        public static string StartRender = "StartRender";

        public static string Stoprender = "StopRender";

        public static string CleanScreen = "CleanScreen";
    }
}
