using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XF.CForm
{
    public partial class DateTimeCompareString : Form
    {
        public DateTimeCompareString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(@"[^\d]");
            
            textBox3.Text = r.Replace(textBox1.Text, "");
        }

        private void DateTimeCompareString_Load(object sender, EventArgs e)
        {
            //textBox2.Text=DateTime.Now.ToShortTimeString();
            //textBox2.Text = DateTime.Now.ToLongTimeString();

            dateEdit1.EditValue = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");

            //var t=(DateTime)(dateEdit1.EditValue.ToString("yyyy/MM/dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo));
            //var t=dateEdit1.Properties.DisplayFormat;
            //var y = dateEdit1.EditValue;
            //textBox1.Text = t.ToString();
            //textBox2.Text = y.ToString();
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.YearMonthPattern = "yyyy-MM-dd HH:mm:ss";
            var dt=Convert.ToDateTime(dateEdit1.EditValue.ToString(),dtFormat);
            var x=dt.ToString("HHmmss");
            var y = dt.ToString("yyyyMMdd");
            Regex r = new Regex(@"[^\d]");
            x = r.Replace(x, "");
            y = r.Replace(y, "");
            textBox1.Text = x;
            textBox2.Text = y;
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = dateEdit1.EditValue.ToString();
        }
    }
}
