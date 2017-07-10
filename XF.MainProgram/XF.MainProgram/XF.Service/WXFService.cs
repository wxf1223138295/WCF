using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF.Contract;
using XF.sBaseMethod;

namespace XF.Service
{
    public class WXFService: IWXFContract
    {
        public DataSet GetPatientInfo()
        {
            string sql = "select top 10* from 系统_病人基本信息表";
            var t = XFSQLDrive.Query(sql);
            return t;
        }
    }
}
