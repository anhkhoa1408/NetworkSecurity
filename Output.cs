using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NETWORK_SECURITY_APP
{
    public partial class Output : Form
    {
        public static int i = 0;
        public static string[] temp;
        public Output()
        {
            InitializeComponent();
            Main main = new Main();
        }

        public Output(string[] result)
        {
            InitializeComponent();
            temp = result;
            decryptOutputBox.Text = temp[i];
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            i = 0;
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (i < temp.Length - 1)
            {
                i++;
                decryptOutputBox.Text = temp[i];
            }
        }

        public void Output_FormClosed(object sender, FormClosedEventArgs e)
        {
            i = 0;
        }
    }
}
