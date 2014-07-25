using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Uri[] baseAddresses = new Uri[] { 
                  new Uri("net.tcp://localhost:8734/Design_Time_Addresses/ConsoleApplication1/Service1/")
              };
                ServiceHost host = new ServiceHost(typeof(Service1));
                ServiceHost host1 = new ServiceHost(typeof(Service2));
                host1.Open();
                host.Open();

                Console.WriteLine("服务已启动！");
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine("服务启动失败："+ex.Message);
                Console.ReadKey();

            }
            
        }
    }
}
