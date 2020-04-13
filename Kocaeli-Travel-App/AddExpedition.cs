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
    public partial class AddExpedition : Form
    {
        public Expedition expedition;
        Commander announcement = new Commander();
        public AddExpedition()
        {
            InitializeComponent();

            id.Text = (Form1.id + 1).ToString();
            announcement.InfoLogger("Sefer ekleme sayfası açıldı");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (road.SelectedItem != null && capacity.Text != "" && time.Text != "" && price.Text != "" && licancePlate.Text != "" && captain.Text != "")
            {
                expedition = new Expedition(
                id.Text,
                road.Text,
                date.Text.ToString(),
                time.Text,
                capacity.Text,
                price.Text,
                licancePlate.Text,
                captain.Text
              );

                for (int i = 0; i < int.Parse(capacity.Text); i++)
                {
                    expedition.Armchairs.myAdd(new Armchair((i + 1).ToString(), "", "", "Boş", price.Text));
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
                announcement.InfoLogger("Kullanıcı sefer oluşturdu!");
                //Form1.id++;
                //Form1.Count++;
            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgileri doğru bir şekilde doldurunuz!");
                announcement.WarnLogger("Kullanıcı tüm bilgileri doldurmadan sefer eklemek istedi!");
            }
        }

        private void time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void capacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
