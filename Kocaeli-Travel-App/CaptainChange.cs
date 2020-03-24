using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kocaeli_Travel_App
{
    public partial class CaptainChange : Form
    {
        public string changeName;
        public CaptainChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeName = textBox1.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
