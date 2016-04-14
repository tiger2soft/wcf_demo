using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using Services;
using Contracts;
using System.ServiceModel.Description;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                //代码方式创建endpoint
                //host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "http://127.0.0.1:9999/calculatorservice");
                //if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                //{
                //    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                //    behavior.HttpGetEnabled = true;
                //    behavior.HttpGetUrl = new Uri("http://127.0.0.1:9999/calculatorservice/metadata");
                //    host.Description.Behaviors.Add(behavior);
                //}

                host.Opened += delegate
                {
                    Console.WriteLine("CalculatorService服务已经启动，按任意键终止服务!");
                };
                host.Open();
                Console.ReadKey();
            }
        }
    }
}
