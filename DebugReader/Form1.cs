using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebugReader
{
    public partial class Form1 : Form
    {
        private bool isDebugObjectLoaded;
        public Form1()
        {
            InitializeComponent();

            if (ExtDebugClient.Intialize() > 0)
                MessageBox.Show("Could not initialize debug client");
            else
                isDebugObjectLoaded = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isDebugObjectLoaded)
                return;

            textBox1.Text = ExtDebugClient.GetData();
            ExtDebugClient.Terminate();
        }
    }
}