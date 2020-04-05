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
      //  public static int x = 1;

        Commander announcement = new Commander();

        public AddExpedition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Todo Sefer ekle

       if(road.SelectedItem!=null && capacity.Text!="" && time.Text!="" && price.Text!="" && licancePlate.Text!="" && captain.Text!="")
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
            }
       else
            {
                MessageBox.Show("Lütfen tüm bilgileri doğru bir şekilde doldurunuz!");
                announcement.WarnLogger("Kullanıcı tüm bilgileri doldurmadan sefer eklemek istedi!");

            }
          
        }
        private void AddExpedition_Load(object sender, EventArgs e)
        {
              int c = Form1.expeditionCounter + 1;
           id.Text = c.ToString();
             
            

            /*
            int sefer = expeditionListView.Items.Count + 1;
           MessageBox.Show(sefer.ToString());
           MessageBox.Show(expeditionCounter.ToString());
           if (sefer > expeditionCounter)
            {

            }
            else
            {

            }
            */
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void capacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void captain_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                        && !char.IsSeparator(e.KeyChar);
        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
