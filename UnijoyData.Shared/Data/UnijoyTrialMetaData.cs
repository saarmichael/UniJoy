using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assets.Data;

namespace Assets.Network.Retrievers
{
    [JsonObject]
    public class UnijoyTrialMetaData : ITrialData
    {


        public string Source { get ; set ; }
        
        public List<float> X { get; set; }
        
        public List<float> Y { get; set; }
        
        public List<float> Z { get; set; }
        
        public List<float> RX { get; set; }
        
        public List<float> RY { get; set; }
        
        public List<float> RZ { get; set; }
        
        public int NumOfObjects { get; set; }
        
        public ColorData ColorData { get; set; }
        
        public ObjectType ObjectType { get; set; }
    }
}
