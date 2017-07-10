using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Linq;
using System.Xml;
using XF.BaseFun;

namespace XF.CForm
{
    public partial class DoWithFile : Form
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr _lopen(string lpPathName, int iReadWrite);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hObject);
        public const int OF_READWRITE = 2;
        public const int OF_SHARE_DENY_NONE = 0x40;
        public readonly IntPtr HFILE_ERROR = new IntPtr(-1);
        public DoWithFile()
        {
            InitializeComponent();
        }
        string path = @"D:\Test\test.Log";
        private void FileStreamName_Click(object sender, EventArgs e)
        {
            using (FileStream filewrite = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
            {
                string wtemp = textBox1.Text;
                var bytes = Encoding.GetEncoding("GB2312").GetBytes(wtemp);
                filewrite.Write(bytes, 0, bytes.Length);
                var t = filewrite.Position;
                var s = filewrite.Length;
                filewrite.Flush();
            }
        }

        private void DoWithFile_Load(object sender, EventArgs e)
        {

        }

        private void PathClass_Click(object sender, EventArgs e)
        {
            var t = Path.GetFileName(path);

        }
        private void filestrread_Click(object sender, EventArgs e)
        {
            Thread th1 = new Thread(new ThreadStart(文件流读));
            th1.IsBackground = true;
            th1.Start();
        }
        public void 文件流读()
        {
            Action<string> del = (str) =>
            {
                using (FileStream fread = new FileStream(path, FileMode.Open))
                {
                    byte[] bytese = new byte[fread.Length];
                    var s = fread.Read(bytese, 0, bytese.Length);
                    string myStr = System.Text.Encoding.GetEncoding("GB2312").GetString(bytese);

                    richTextBox1.Clear();
                    richTextBox1.Text = "走完了转码";
                }
            };
            richTextBox1.Invoke(del, "");


        }
        private void FileClass_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    //var x = System.Text.Encoding.ASCII.GetBytes(path);
                    int fl = (int)fs.Length;
                    byte[] b = new byte[fl];
                    fs.Read(b, 0, b.Length);

                    richTextBox1.Text = System.Text.Encoding.GetEncoding("GB2312").GetString(b);
                    //if (hex.Length % 2 != 0)
                    //{
                    //    hex += "20";//空格
                    //                //throw new ArgumentException("hex is not a valid number!", "hex");
                    //}

                    //// 需要将 hex 转换成 byte 数组。
                    //byte[] bytes = new byte[hex.Length / 2];

                    //for (int i = 0; i < bytes.Length; i++)
                    //{
                    //    try
                    //    {
                    //        // 每两个字符是一个 byte。
                    //        bytes[i] = byte.Parse(hex.Substring(i * 2, 2),
                    //            System.Globalization.NumberStyles.HexNumber);
                    //    }
                    //    catch
                    //    {
                    //        // Rethrow an exception with custom message.
                    //        throw new ArgumentException("hex is not a valid hex number!", "hex");
                    //    }
                    //}
                    //System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");

                    //richTextBox1.Text = chs.GetString(bytes);
                    ////richTextBox1.Text = File.ReadAllText(path);
                    //using (StreamReader sr = new StreamReader(path, Encoding.ASCII))
                    //{
                    //    char[] byteRse = new char[fs.Length];
                    //    sr.Read(byteRse, 0, byteRse.Length);
                    //    byte[] myStr = System.Text.Encoding.ASCII.GetBytes(byteRse);
                    //    //var result = sr.ReadToEnd();
                    //    string myStrS = System.Text.Encoding.UTF8.GetString(myStr);
                    //    richTextBox1.Text = myStrS;
                    //}
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter stwrite = new StreamWriter(path, false, Encoding.GetEncoding("GB2312")))
            {
                stwrite.Write(textBox1.Text);
                stwrite.Flush();
            }
        }

        private void StreamReadWrite_Click(object sender, EventArgs e)
        {
            using (StreamReader stread = new StreamReader(path, Encoding.GetEncoding("GB2312")))
            {
                //File.AppendAllText(path, stread.Read().ToString()); 
                //while(stread.Peek()>-1)
                //{
                //peek是用来确定你read的文件是否结束了，如果结束了会返回int型 -1 ，
                //举个例子，你可以在输出每一行之前检查一下文件是否结尾，如果没结束就输出此行
                //}

                richTextBox1.Text = stread.ReadToEnd();
                if (stread.EndOfStream)
                {
                    richTextBox1.Text = richTextBox1.Text + "End";
                }
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            IntPtr vHandle = _lopen(path, OF_READWRITE | OF_SHARE_DENY_NONE);
            if (vHandle == HFILE_ERROR)
            {
                MessageBox.Show("文件被占用！");
                return;
            }
            CloseHandle(vHandle);
            MessageBox.Show("没有被占用！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument xdoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));


            XElement pt = new XElement("FPOPER", new XElement("ID", "INV"), new XElement("DATA"));

            xdoc.Add(pt);

            XElement ptxml = new XElement("PT", new XElement("InfoKind", 2), new XElement("SellerAddress", 0), new XElement("InfoClientName", "pt.InfoClientName"), new XElement("InfoClientTaxCode", ""), new XElement("InfoClientBankAccount", ""), new XElement("InfoClientAddressPhone", "pt.InfoClientAddressPhone"), new XElement("InfoSellerBankAccount", "pt.InfoSellerBankAccount"), new XElement("InfoSellerAddressPhone", "pt.InfoSellerAddressPhone"), new XElement("InfoTaxRate", 0), new XElement("InfoNotes", "pt.InfoNotes"), new XElement("InfoInvoicer", "pt.InfoInvoicer"), new XElement("InfoChecker", ""), new XElement("InfoCashier", ""), new XElement("InfoListName", ""), new XElement("InfoBillNumber", "pt.InfoBillNumber"));

            XElement mxxml = new XElement("MX");

            XElement a = new XElement("数字", 1);

            XElement b = new XElement("英文", "a");

            List<XElement> list = new List<XElement>();

            list.Add(a);
            list.Add(b);

            mxxml.Add(list);

            XElement[] param1 = new XElement[] { ptxml, mxxml };
        
            XElement DATAtree = pt.Element("DATA");
            DATAtree.Add(param1);


            //XElement mxXml = new XElement("MX", new XElement("ITEM", new XElement("ListIndex", "item.ListIndex"), new XElement("ListGoodsName", "item.ListGoodsName"), new XElement("ListTaxItem", ""), new XElement("ListStandard", "item.ListStandard"), new XElement("ListUnit", "item.ListUnit"), new XElement("ListNumber", "item.ListNumber"), new XElement("ListPrice", "item.ListPrice"), new XElement("ListAmount", "item.ListAmount"), new XElement("ListPriceKind", 0), new XElement("ListTaxAmount", 0)));


            //DATAtree.Add(param);


            //var t = xdoc.Declaration.ToString() + Environment.NewLine + ptxml.ToString();

            #region XML元素
            //XmlDocument xmlDoc = new XmlDocument();
            ////创建类型声明节点  
            //XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            //xmlDoc.AppendChild(node);

            //XmlNode root = xmlDoc.CreateElement("InterfaceInfo");
            //xmlDoc.AppendChild(root);
            //XmlAttribute xattibute = xmlDoc.CreateAttribute("EquipTypeID");
            //xattibute.Value = EquipTypeID;
            //root.Attributes.Append(xattibute);

            //XmlNode nodeInData = xmlDoc.CreateElement("InData");
            //root.AppendChild(nodeInData);
            //var cDataStr = xmlDoc.CreateCDataSection(DataStr);
            //nodeInData.AppendChild(cDataStr);
            //return xmlDoc.OuterXml;
            #endregion

            richTextBox1.Clear();
            richTextBox1.Text = xdoc.Declaration+Environment.NewLine+ xdoc.ToString();
        }
    }
}
