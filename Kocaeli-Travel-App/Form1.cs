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
        MyList<Expedition> myList;
        string path;
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
            path = @"C:\Users\onurk\Desktop\" + date + ".txt";


            //TODO eğer masaüstünde yoksa dosya

            expeditionListView.Columns.Add("Id");
            expeditionListView.Columns.Add("Road");
            expeditionListView.Columns.Add("Date");
            expeditionListView.Columns.Add("Time");
            expeditionListView.Columns.Add("Capacity");
            expeditionListView.Columns.Add("Price");
            expeditionListView.Columns.Add("LicencePlate");
            expeditionListView.Columns.Add("Captain");

            armchairListView.Columns.Add("Id");
            armchairListView.Columns.Add("Name");
            armchairListView.Columns.Add("Gender");
            armchairListView.Columns.Add("State");
            armchairListView.Columns.Add("Price");

            printToMyList(path);
            printToExpeditionListView();
        }
        public void printToMyList(string path)
        {
            myList = new MyList<Expedition>();

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
                            string[] armchairArray = item.Split(' ');
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

            //Todo list'i yollama burada doldur printtolistbox
        }
        public void printToExpeditionListView()
        {
            ListViewItem listViewItem;
            Node<Expedition> current = myList._head;

            if (current == null)
            {
                MessageBox.Show("Sefer Yok");
                return;
            }
            else
            {
                expeditionListView.Items.Clear();
                while (current != null)
                {
                    string[] expeditionData =
                    {
                        current.Data.Id,
                        current.Data.Road,
                        current.Data.Date,
                        current.Data.Time,
                        current.Data.Capacity,
                        current.Data.Price,
                        current.Data.LicencePlate,
                        current.Data.Captain
                    };
                    listViewItem = new ListViewItem(expeditionData);
                    expeditionListView.Items.Add(listViewItem);
                    current = current.Next;
                }
            }
        }
        public void printToArmchairListView(string id)
        {
            ListViewItem listViewItem;
            Node<Expedition> current = myList._head;
            armchairListView.Items.Clear();

            while (current.Data.Id != id)
            {
                current = current.Next;
            }

            Node<Armchair> armChairCurrent = current.Data.Armchairs._head;

            while (armChairCurrent != null)
            {
                string[] armchairData =
                    {
                        armChairCurrent.Data.Id,
                        armChairCurrent.Data.Price,
                        armChairCurrent.Data.Name,
                        armChairCurrent.Data.Gender,
                        armChairCurrent.Data.State

                    };
                listViewItem = new ListViewItem(armchairData);
                armchairListView.Items.Add(listViewItem);
                armChairCurrent = armChairCurrent.Next;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Todo Ekle, id yi kendisi versin
            AddExpedition addExpedition = new AddExpedition();
            addExpedition.ShowDialog();
            myList.myAdd(addExpedition.expedition);

            List<string> addNew = new List<string>();
            addNew.Add(addExpedition.expedition.Id);
            addNew.Add(addExpedition.expedition.Road);
            addNew.Add(addExpedition.expedition.Date);
            addNew.Add(addExpedition.expedition.Time);
            addNew.Add(addExpedition.expedition.Capacity);
            addNew.Add(addExpedition.expedition.Price);
            addNew.Add(addExpedition.expedition.LicencePlate);
            addNew.Add(addExpedition.expedition.Captain);
            addNew.Add("");

            Node<Armchair> current = addExpedition.expedition.Armchairs._head;
            string textArmchair;
            while (current != null)
            {
                textArmchair = current.Data.Id + " " + current.Data.Price + " " + current.Data.Name + " " + current.Data.Gender + " " + current.Data.State;
                addNew.Add(textArmchair);
                current = current.Next;
            }
            addNew.Add("");

            File.AppendAllLines(path, addNew);
            printToExpeditionListView();
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
            openFileDialog1.Filter = "Text Dosyası |*.txt";
            openFileDialog1.Title = "Sefer Seç";
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            printToMyList(path);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Todo Bilet Satın Al
        }
        private void expeditionListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            printToArmchairListView(e.Item.Text);
        }
    }
}
