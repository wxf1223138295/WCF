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

namespace XF.CForm
{
    public partial class Patientnfo : Form
    {
        public Patientnfo()
        {
            InitializeComponent();
        }
        ProxyBase client = new ProxyBase();
        private void PatientInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t = client.GetPatientInfo().Tables[0];
            dataGridView1.DataSource = t;

            string wtemp = @"<a><b></b></a><c><d></d></c>";

            using (FileStream fs = new FileStream(@"D:\Test\test.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] bytes1 = new byte[1024];
                bytes1 = Encoding.UTF8.GetBytes(wtemp);
                fs.Write(bytes1, 0, bytes1.Length);
            }
        }
  
        private void button2_Click(object sender, EventArgs e)
        {
            DoWithFile d = new DoWithFile();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTimeCompareString fr = new DateTimeCompareString();
            fr.Show();
        }
    }

}
