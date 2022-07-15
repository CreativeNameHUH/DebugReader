using System;
using System.Windows.Forms;

namespace DLLTestApp
{
    public partial class MainForm : Form
    {
        private bool _isDebugServerInitialized;
        public MainForm()
        {
            InitializeComponent();

            int result = ExtDebugServer.Initialize();
            if (result > 0)
            {
                MessageBox.Show("Failed to initialize debug server. ERROR: " + result);
            }
            else
            {
                _isDebugServerInitialized = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (!_isDebugServerInitialized)
                return;
            
            ExtDebugServer.SendData(TextBox1.Text, TextBox1.Text.Length);
            //ExtDebugServer.Terminate();
        }
    }
}