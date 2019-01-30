using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace SimpleService
{
    [ServiceContract]
    public interface IDetectionService
    {
        [OperationContract]
        IEnumerable<string> DetectInstruments(string startsWith);
    }


    public class DetectionService : IDetectionService
    {
        public IEnumerable<string> DetectInstruments(string startsWith)
        {
            return new[]
            {
                "abe",
                "abekat",
                "missekat",
                "kattemis",
                "fedebadeabe",
            }.Where(s => s.StartsWith(startsWith));
        }
    }
}
