using System;
using System.Collections.Generic;
using System.Text;

namespace UnijoyData.Shared.Data
{
    public interface IRenderData
    {
        (float, float) ClipPlanes { get; set; }

        (float, float, float) EyeOffsets { get; set; }

        (float, float, float) HeadCenter { get; set; }

        (float, float) ScreenDimension { get; set; }
    }
}
