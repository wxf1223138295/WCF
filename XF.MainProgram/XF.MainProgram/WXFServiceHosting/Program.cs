using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using XF.Service;

namespace WXFServiceHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uri[] baseaddress = new Uri[2];
            //baseaddress[0] = new Uri("http://127.0.0.1:9997/WXFService");
            //baseaddress[1] = new Uri("net.tcp://127.0.0.1:9999/WXFService");
            //using (ServiceHost host = new ServiceHost(typeof(WXFService), baseaddress))
            //{

            //}
            //AddressHeader addresshead = AddressHeader.CreateAddressHeader("王晓锋", "http://127.0.0.1:9997/WXFService","不知道");
            using (ServiceHost host = new ServiceHost(typeof(WXFService)))
            {
                //host.AddServiceEndpoint("XF.Contract.IWXFContract", new NetTcpBinding(), "net.tcp://127.0.0.1:9999/WXFService");
                //var t = host.Description;


                DateTime dtNow = DateTime.Now;
                host.Opened += delegate
                {
                    foreach(var t in host.BaseAddresses)
                    {
                        Console.WriteLine("基地址：" + t.ToString());
                    }                 
                    Console.WriteLine("启动时间：" + dtNow);
                    Console.WriteLine("服务已经启动，按任意键终止服务！");
                };

                host.Open();
                Console.Read();
            }
        }
    }
}
