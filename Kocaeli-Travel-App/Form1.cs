using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kocaeli_Travel_App
{
    public partial class Form1 : Form
    {
        MyList<Expedition> myList = new MyList<Expedition>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MyList<Expedition> myList = new MyList<Expedition>();
            //Expedition expedition = new Expedition("1","Kocaeli-İstanbul","13.02.2020","15.00","15","100TL","34ki34","20");
            //expedition.Armchairs.Add(new Armchair("1","100TL","Onur","Erkek","Dolu"));
            //expedition.Armchairs.Add(new Armchair("2", "100TL", "Salih", "Erkek", "Dolu"));
            //expedition.Armchairs.Add(new Armchair("3", "100TL", "Falan", "Erkek", "Dolu"));
            ////kocaeli.Armchairs.PrintList();
            //myList.Add(expedition);

            //expedition = new Expedition("2", "Ankara-İstanbul", "13.02.2020", "15.00", "15", "100TL", "34ki34", "20");
            //expedition.Armchairs.Add(new Armchair("1", "100TL", "Onur", "Erkek", "Dolu"));
            //expedition.Armchairs.Add(new Armchair("2", "100TL", "Ömer", "Erkek", "Rezerve"));
            //expedition.Armchairs.Add(new Armchair("3", "100TL", "Emre", "Erkek", "Dolu"));
            ////kocaeli.Armchairs.PrintList();

            //myList.Add(expedition);
            //MessageBox.Show("");
            //myList.Add(kocaeli);
            //myList.PrintList();


            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string path = @"C:\Users\onurk\Desktop\"+ date+".txt";

            //TODO eğer masaüstünde yoksa dosya
            string[] readText = File.ReadAllLines(path, Encoding.UTF8);

            List<string> expeditionData = new List<string>();
            List<string> armchairData = new List<string>();

            bool test = true;

            Expedition expedition = new Expedition();

            foreach (string readLine in readText)
            {
                if (readLine == "")
                {
                    if (test)
                    {
                        expedition = new Expedition(
                            expeditionData[0],
                            expeditionData[1],
                            expeditionData[2],
                            expeditionData[3],
                            expeditionData[4],
                            expeditionData[5],
                            expeditionData[6],
                            expeditionData[7]
                            );
                        expeditionData.Clear();
                    }
                    else
                    {
                        foreach (var item in armchairData)
                        {
                            string [] armchairArray = item.Split(' ');
                            expedition.Armchairs.myAdd(
                                new Armchair(
                                    armchairArray[0],
                                    armchairArray[1],
                                    armchairArray[2],
                                    armchairArray[3],
                                    armchairArray[4]
                                    )
                                ); 
                        }
                        armchairData.Clear();
                        myList.myAdd(expedition);
                    }

                    test = !test;
                    continue;
                }
                if (test)
                {
                    expeditionData.Add(readLine);
                }
                else
                {
                    armchairData.Add(readLine);
                }
            }


            myList.PrintList(listBox1);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            myList.PrintList(listBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Todo Ekle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Todo sil
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Todo kaptan değiştir
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Todo gelir hesapla
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Todo Sefer seç
        }
    }
}
