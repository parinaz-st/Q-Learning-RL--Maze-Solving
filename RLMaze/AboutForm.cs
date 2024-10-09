using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RLMaze
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            MyInitialize();
        }

        private void MyInitialize()
        {
            this.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
