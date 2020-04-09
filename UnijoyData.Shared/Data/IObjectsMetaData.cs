using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnijoyData.Shared.Data
{
    public interface IObjectsMetaData
    {
        int NumOfObjects { get; set; }

        ColorData ColorData { get; set; }

        ObjectType ObjectType { get; set; }
    }
}
