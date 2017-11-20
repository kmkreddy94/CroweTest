using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CroweHorwath.Client;
using CroweHorwath.Client.HelloService;

namespace CroweHorwath.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloServiceClient wcfClient = new HelloServiceClient();
            CompositeType obj = new CompositeType();
            obj.BoolValue = true;
            obj.StringValue = "Hello WCF TCP client!";
            CompositeType objret = wcfClient.GetDataUsingDataContract(obj);
            Console.WriteLine("GetDataUsingDataContract returns: " + objret.StringValue);
            Console.ReadLine();
            wcfClient.Close();

        }
    }
}
