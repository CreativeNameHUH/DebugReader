using System;
using System.Windows.Forms;

namespace DLLTestApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (ExtDebugConnector.IsDataAvailable())
            {
                TextBox1.Text = ExtDebugConnector.GetInt().ToString();
            }
            else
            {
                ExtDebugConnector.SetInt(Convert.ToInt32(TextBox1.Text));
            }
        }
    }
}