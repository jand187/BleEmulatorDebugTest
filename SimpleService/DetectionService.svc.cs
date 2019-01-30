using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace SimpleService
{
    [ServiceContract]
    public interface IDetectionService
    {
        [OperationContract]
        IEnumerable<string> DetectInstruments(string contains);
    }


    public class DetectionService : IDetectionService
    {
        public IEnumerable<string> DetectInstruments(string contains)
        {
            return new[]
            {
                "abe",
                "abekat",
                "missekat",
                "kattemis",
                "fedebadeabe",
            }.Where(s => s.Contains(contains));
        }
    }
}
