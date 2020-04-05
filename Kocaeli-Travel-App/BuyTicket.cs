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
    public partial class BuyTicket : Form
    {
        Commander announcement = new Commander();
        public Data data;
        public BuyTicket()
        {
            InitializeComponent();

            stateComboBox.Items.Add(new ComboboxItem { Text = "Satın Al", Value = "Dolu" });
            stateComboBox.Items.Add(new ComboboxItem { Text = "Rezerve Et", Value = "Rezerve" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text != null)
            {
                data = new Data(
              name.Text,
              gender2.Text,
              (stateComboBox.SelectedItem as ComboboxItem).Value.ToString()
              );

                this.DialogResult = DialogResult.OK;
                this.Close();
                announcement.InfoLogger("Bilet Satın Alındı!");
            }
            else
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz!");
       
    }
       
            

        private void BuyTicket_Load(object sender, EventArgs e)
        {

        }

        private void gender2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
    public class Data
    {
        public string Name { get; set; }
        public string Gender2 { get; set; }
        public string State { get; set; }

        public Data(string Name, string Gender, string State)
        {
            this.Name = Name;
            this.Gender2 = Gender;
            this.State = State;
        }
    }
}
