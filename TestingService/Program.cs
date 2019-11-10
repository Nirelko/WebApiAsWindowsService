using System;
using System.ServiceProcess;

namespace TestingService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var service = new TestSevice())
            {
                ServiceBase.Run(service);
            }
        }
    }
}
