using System;
using System.Collections.Generic;
using System.Text;

namespace UnijoyData.Shared.Data
{
    public interface ISphereFieldMetaData
    {
        float Density { get; set; }

        int Coherence { get; set; } //(% out of 100)

        (float, float, float ) StarFieldDimension { get; set; }
    }
}
