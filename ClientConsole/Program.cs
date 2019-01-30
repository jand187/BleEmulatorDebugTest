using System;
using System.Linq;
using System.ServiceModel;
using SimpleService;

namespace ClientConsole
{
    public class Program
    {
        private static readonly Uri baseAddress;

        static Program()
        {
            baseAddress = new Uri("http://localhost:62363/DetectionService.svc");
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Press any key to call service");
            Console.ReadKey();

            var factory = new ChannelFactory<IDetectionService>(new BasicHttpBinding());
            var endpointAddress = new EndpointAddress(baseAddress);
            var channel = factory.CreateChannel(endpointAddress);

            var instruments = channel.DetectInstruments("ab");

            instruments.ToList().ForEach(Console.Write);
        }
    }
}
