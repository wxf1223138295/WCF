using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF.cBaseProxy;
using XF.Contract;

namespace XF.CForm
{
    public class ProxyBase: XFClientBase<IWXFContract>
    {
        public ProxyBase() : base("127.0.0.1", "WXFService", 9999)
        {

        }
        public DataSet GetPatientInfo()
        {
            return base.Channel.GetPatientInfo();
        }
    }
}
