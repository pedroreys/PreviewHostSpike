using System;
using System.Windows.Forms;

namespace WinFormPreviewHostSpike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            
            if(result == DialogResult.OK)
            {
                previewHandlerHost.Open(dialog.FileName);
            }
        }
    }
}
