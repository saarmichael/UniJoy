using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnijoyData.Shared.Data
{
    public interface IObjectsMetaData
    {
        //int NumOfObjects { get; set; }

        ColorData ColorData { get; set; }

        ObjectType ObjectType { get; set; }

        float Density { get; set; }

        //int LifeTime { get; set; }

        int Coherence { get; set; } //(% out of 100)

        //float DiscAmplitudes { get; set; }

        //float Distance { get; set; }

        //float AdaptationAngle { get; set; }

        float BaseSize { get; set; }

        float HeightSize { get; set; }
    }
}
