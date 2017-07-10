using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data;
using System.Threading.Tasks;

namespace XF.Contract
{
    [ServiceContract]
    public interface IWXFContract
    {
        [OperationContract]
        DataSet GetPatientInfo();
    }
}
