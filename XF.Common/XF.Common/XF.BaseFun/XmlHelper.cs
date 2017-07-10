using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XF.BaseFun
{
    public class XmlHelper
    {
        public static string AddInfoXml(string DataStr)
        {
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明节点  
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);

            return xmlDoc.OuterXml+Environment.NewLine+ DataStr;
        }
    }
}
