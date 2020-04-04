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
        public static int x = 1;
        Commander announcement = new Commander();


        public AddExpedition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Todo Sefer ekle
        //    x = x + 1;
        if(road.SelectedItem!=null  || capacity.Text!="" || price.Text!="" || licancePlate.Text!="" || captain.Text!="")
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
                announcement.InfoLogger("Sefer Eklendi!");
            }
           
        else
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz!");
            }
           

        }

        private void AddExpedition_Load(object sender, EventArgs e)
        {
            id.Text = x.ToString();
       
           

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

        private void capacity_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
