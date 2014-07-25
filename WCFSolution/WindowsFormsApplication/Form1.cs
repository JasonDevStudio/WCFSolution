using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.IService1 isc = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
            var msg =isc.DoWork(new ClassLibrary1.ClassModel(),"测试结果:OK");
            MessageBox.Show(msg);
        }
    }
}
