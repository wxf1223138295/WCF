using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Xml;

namespace XF.cBaseProxy
{
    public class XFClientBase<T>: ClientBase<T> where T:class
    {
        private static NetTcpBinding NetTcp
        {
            get
            {
                return new NetTcpBinding()
                {
                    Security = new NetTcpSecurity()
                    {
                        Mode = SecurityMode.None,
                        Transport = new TcpTransportSecurity() { ClientCredentialType = TcpClientCredentialType.Windows },
                        Message = new MessageSecurityOverTcp() { ClientCredentialType = MessageCredentialType.Windows }
                    },
                    MaxBufferPoolSize = 524288000,
                    MaxBufferSize = 524288000,
                    MaxReceivedMessageSize = 524288000,
                    CloseTimeout = TimeSpan.FromMinutes(2),
                    OpenTimeout = TimeSpan.FromMinutes(2),
                    SendTimeout = TimeSpan.FromMinutes(2),
                    ReceiveTimeout = TimeSpan.FromMinutes(10),
                    ReliableSession = new OptionalReliableSession() { InactivityTimeout = TimeSpan.FromHours(8), Enabled = true, Ordered = true },
                    ReaderQuotas = new System.Xml.XmlDictionaryReaderQuotas()
                    {
                        MaxArrayLength = 524288000,
                        MaxBytesPerRead = 524288000,
                        MaxDepth = 524288000,
                        MaxNameTableCharCount = 524288000,
                        MaxStringContentLength = 524288000
                    },
                    TransferMode = TransferMode.Buffered
                };
            }
        }
        private void SetChannelFactory(ChannelFactory _ChannelFactory)
        {
            foreach (OperationDescription _OperationDescription in this.ChannelFactory.Endpoint.Contract.Operations)
            {
                DataContractSerializerOperationBehavior dataContractBehavior =
                            _OperationDescription.Behaviors.Find<DataContractSerializerOperationBehavior>()
                            as DataContractSerializerOperationBehavior;
                if (dataContractBehavior != null)
                    dataContractBehavior.MaxItemsInObjectGraph = 524288000;
            }
        }
        public XFClientBase(string _AddressUrl, string _ServiceName, int _Port) : base(NetTcp, new EndpointAddress("net.tcp://" + _AddressUrl + ":" + _Port + "/" + _ServiceName)) { SetChannelFactory(this.ChannelFactory); }

        #region 其他配置WCF连接方式
        //public XFClientbase(string configname) : base(configname)
        //{

        //}
        //public XFClientbase(System.ServiceModel.Channels.Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
        //{
        //}
        //public XFClientbase() : base(NetTcp, new EndpointAddress(AddressUrl)) { SetChannelFactory(this.ChannelFactory); }
        //public XFClientbase(string _AddressUrl, int _Port) : base(NetTcp, new EndpointAddress(AddressUrl)) { SetChannelFactory(this.ChannelFactory); }
        #endregion
    }
}
