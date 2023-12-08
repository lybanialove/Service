using System;
using System.ServiceModel;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Service.ServiceContext)))
            {
                host.Open();
                Console.WriteLine("Host is started!");
                Console.ReadLine();
            }
        }
    }
}
