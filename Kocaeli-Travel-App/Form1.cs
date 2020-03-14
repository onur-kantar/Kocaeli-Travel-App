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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyList<Expedition> myList = new MyList<Expedition>();
            Expedition kocaeli = new Expedition();
            kocaeli.Armchairs.Add(new Armchair());
            kocaeli.Armchairs.Add(new Armchair());
            kocaeli.Armchairs.Add(new Armchair());
            kocaeli.Armchairs.PrintList();

            Expedition istanbul = new Expedition();
            istanbul.Armchairs.Add(new Armchair());
            istanbul.Armchairs.Add(new Armchair());
            istanbul.Armchairs.Add(new Armchair());
            istanbul.Armchairs.PrintList();

            myList.Add(kocaeli);
            myList.Add(istanbul);
            myList.PrintList();
        }
    }
}
