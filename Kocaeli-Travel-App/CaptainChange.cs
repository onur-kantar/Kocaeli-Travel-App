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
        Commander announcement = new Commander();
        public string changeName;
        public CaptainChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (captain.Text != "")
            {
                changeName = captain.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
                announcement.InfoLogger("Kaptan değiştirildi!");
            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgileri doğru bir şekilde doldurunuz!");
                announcement.WarnLogger("Kullanıcı tüm bilgileri doldurmadan sefer eklemek istedi!");
            }
        }
    }
}
