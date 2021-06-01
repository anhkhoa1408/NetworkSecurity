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
        }

        public Output(string[] result)
        {
            InitializeComponent();
            temp = result;
            decryptOutputBox.Text = temp[i];
            i++;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            i = 0;
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            decryptOutputBox.Text = temp[i];
            if (i < temp.Length - 1)
            {
                i++;
            }
        }

        private void Output_FormClosed(object sender, FormClosedEventArgs e)
        {
            i = 0;
        }
    }
}
