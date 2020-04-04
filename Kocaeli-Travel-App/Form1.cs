﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing;
using System.Diagnostics;

namespace Kocaeli_Travel_App
{


    public partial class Form1 : Form
    {
        Commander announcement = new Commander();

        MyList<Expedition> myList;
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //      Commander test = new Commander();
            announcement.InfoLogger("asdsa");
            announcement.DebugLogger("asdas");



            //Todo / .
            //Todo pc'den pc'ye değişme olayı 
            string date = DateTime.Now.ToString("dd.MM.yyyy");
            string Desktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Desktoppath + "\\" + date + ".txt";

            createListView();
            printToMyList(path);
            printToExpeditionCounter();
        }





        private void createListView()
        {
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
        }

        public void printToExpeditionCounter()
        {

            int expeditionCounter = 0;
            Node<Expedition> current = myList._head;
            while (current != null)
            {
                current = current.Next;
                expeditionCounter++;
            }
            ExpeditionCounter.Text = expeditionCounter.ToString();
        }
        public void printToMyList(string path)
        {
            myList = new MyList<Expedition>();

            if (!File.Exists(path))
            {
                using (File.CreateText(path))
                {
                    return;
                }
            }

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

            printToExpeditionListView();
        }
        public void printToTxtFile()
        {
            Node<Expedition> currentEx = myList._head;
            Node<Armchair> currentAr;
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                while (currentEx != null)
                {
                    streamWriter.WriteLine(currentEx.Data.Id);
                    streamWriter.WriteLine(currentEx.Data.Road);
                    streamWriter.WriteLine(currentEx.Data.Date);
                    streamWriter.WriteLine(currentEx.Data.Time);
                    streamWriter.WriteLine(currentEx.Data.Capacity);
                    streamWriter.WriteLine(currentEx.Data.Price);
                    streamWriter.WriteLine(currentEx.Data.LicencePlate);
                    streamWriter.WriteLine(currentEx.Data.Captain);
                    streamWriter.WriteLine("");

                    currentAr = currentEx.Data.Armchairs._head;
                    while (currentAr != null)
                    {
                        streamWriter.Write(currentAr.Data.Id);
                        streamWriter.Write(" ");
                        streamWriter.Write(currentAr.Data.Name);
                        streamWriter.Write(" ");
                        streamWriter.Write(currentAr.Data.Gender);
                        streamWriter.Write(" ");
                        streamWriter.Write(currentAr.Data.State);
                        streamWriter.Write(" ");
                        streamWriter.Write(currentAr.Data.Price);
                        streamWriter.WriteLine("");

                        currentAr = currentAr.Next;
                    }
                    streamWriter.WriteLine("");
                    currentEx = currentEx.Next;
                }
            }
        }
        public void printToExpeditionListView()
        {
            ListViewItem listViewItem;
            Node<Expedition> current = myList._head;
            expeditionListView.Items.Clear();
            armchairListView.Items.Clear();

            if (current == null)
            {
                return;
            }
            else
            {
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
                        armChairCurrent.Data.Name,
                        armChairCurrent.Data.Gender,
                        armChairCurrent.Data.State,
                        armChairCurrent.Data.Price

                    };
                listViewItem = new ListViewItem(armchairData);
                armchairListView.Items.Add(listViewItem);
                armChairCurrent = armChairCurrent.Next;
            }
        }
        public Node<Expedition> findExpedition(string id)
        {
            Node<Expedition> current = myList._head;

            while (id != current.Data.Id)
            {
                current = current.Next;
            }
            return current;
        }
        public Node<Armchair> findArmchair(Node<Expedition> currentEx)
        {
            string id = armchairListView.SelectedItems[0].Text;
            Node<Armchair> currentAr = currentEx.Data.Armchairs._head;

            while (id != currentAr.Data.Id)
            {
                currentAr = currentAr.Next;
            }
            return currentAr;
        }

        private void add(object sender, EventArgs e)
        {
           
            //Todo Ekle, id yi kendisi versin
            AddExpedition addExpedition = new AddExpedition();
            addExpedition.ShowDialog();
            if (addExpedition.DialogResult == DialogResult.OK)
            {
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
                    textArmchair = current.Data.Id + " " + current.Data.Name + " " + current.Data.Gender + " " + current.Data.State + " " + current.Data.Price;
                    addNew.Add(textArmchair);
                    current = current.Next;
                }
                addNew.Add("");

                File.AppendAllLines(path, addNew);
                printToExpeditionListView();
                printToExpeditionCounter();
                announcement.InfoLogger("Sefer Ekleme sayfasına gidildi");
            }
        }
        private void delete(object sender, EventArgs e)
        {
            //Todo sil
            if (expeditionListView.SelectedItems.Count > 0)
            {
                string id = expeditionListView.SelectedItems[0].Text;
                Node<Armchair> currentAr;

                Node<Expedition> current = findExpedition(id);

                currentAr = current.Data.Armchairs._head;
                while (currentAr != null)
                {
                    if (currentAr.Data.State != "Boş")
                    {
                        MessageBox.Show("Sefer Satılmış Koltuk İçeriyor", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    currentAr = currentAr.Next;
                }

                if (myList._head.Data.Id == id)
                {
                    myList._head = myList._head.Next;
                }
                else
                {
                    Node<Expedition> currentEx = myList._head;

                    while (id != currentEx.Next.Data.Id)
                    {
                        currentEx = currentEx.Next;
                    }
                    currentEx.Next = currentEx.Next.Next;
                }
                printToTxtFile();
                printToMyList(path);
                printToExpeditionListView();
                announcement.InfoLogger("Sefer Silindi");
            }
            else
            {
                MessageBox.Show("Lütfen silinecek olan seferi seçiniz!");
                announcement.InfoLogger("Kullanıcı silmek için herhangi bir sefer seçmedi!");
            }    
        }
        private void captainChange(object sender, EventArgs e)
        {
            if(expeditionListView.SelectedItems.Count > 0)
            {
                //Todo kaptan değiştir
                string id = expeditionListView.SelectedItems[0].Text;
                string captain = expeditionListView.SelectedItems[0].SubItems[7].Text;

                CaptainChange captainChange = new CaptainChange();
                captainChange.ShowDialog();

                if (captainChange.DialogResult == DialogResult.OK)
                {
                    Node<Expedition> current = findExpedition(id);
                    current.Data.Captain = captainChange.changeName;

                    printToTxtFile();
                    printToExpeditionListView();
                }
                announcement.InfoLogger("Kaptan Değiştirme Sayfasına Gidildi");
            }
            else
            {
                MessageBox.Show("Lütfen sefer seçiniz!");
                announcement.WarnLogger("Kullanıcı sefer seçmeden kaptan değiştirmek istedi!");
            }
        }  
        private void calculateIncome(object sender, EventArgs e)
        {
            //Todo gelir hesapla
            if (expeditionListView.SelectedItems.Count > 0)
            {
                string id = expeditionListView.SelectedItems[0].Text;
                Node<Expedition> currentEx = myList._head;
                Node<Armchair> currentAr;
                while (id != currentEx.Data.Id)
                {
                    currentEx = currentEx.Next;
                }
                currentAr = currentEx.Data.Armchairs._head;
                int sum = 0;
                while (currentAr != null)
                {
                    if (currentAr.Data.State == "Dolu" || currentAr.Data.State == "Rezervasyon")
                    {
                        sum = sum + int.Parse(currentAr.Data.Price);
                    }
                    currentAr = currentAr.Next;
                }
                MessageBox.Show(sum.ToString() + " TL", "Toplam Gelir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                announcement.InfoLogger("Kullanıcı ilgili seferin gelir hesaplamasını yaptı");
            }
            else
            {
                MessageBox.Show("Lütfen geliri hesaplanacak bir sefer seçiniz!");
                announcement.WarnLogger("Kullanıcı toplam geliri hesaplamak için listeden bir sefer seçmedi!");
            }         
        }
        private void selectDate(object sender, EventArgs e)
        {
            //Todo dosya seç
            openFileDialog1.Filter = "Text Dosyası |*.txt";
            openFileDialog1.Title = "Sefer Seç";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            printToMyList(path);
            printToExpeditionListView();
        }
        private void ticketBuy(object sender, EventArgs e)
        {
            //Todo Bilet Satın Al
            //Node<Armchair> current = findArmchairWithSelectedId(findExpeditionWithSelectedId());
            if (expeditionListView.SelectedItems.Count > 0 && armchairListView.SelectedItems.Count > 0)
            {
                int itemnumber = armchairListView.SelectedItems[0].Index;

                if (armchairListView.Items[itemnumber].SubItems[3].Text == "Boş")
                {        
                    string id = expeditionListView.SelectedItems[0].Text;
                    BuyTicket buyTicket = new BuyTicket();
                    buyTicket.ShowDialog();
                    if (buyTicket.DialogResult == DialogResult.OK)
                    {
                        Node<Armchair> current = findArmchair(findExpedition(id));

                        current.Data.Name = buyTicket.data.Name;
                        current.Data.Gender = buyTicket.data.Gender2;
                        current.Data.State = buyTicket.data.State;

                        printToTxtFile();
                        printToMyList(path);
                    }
                    announcement.InfoLogger("Kullanıcı bilet alma ekranına ulaştı");
                }
                else
                {     
                    MessageBox.Show("Lütfen boş bir koltuk seçiniz!");
                    announcement.WarnLogger("Kullanıcı dolu bir koltuk seçmeye çalıştı!");
                }   
            }
              else
               {
                MessageBox.Show("Lütfen sefer ve koltuk seçiniz!");
                announcement.WarnLogger("Kullanıcı sefer ve koltuk seçmeden işlem yapmaya çalıştı!");
               }        
        }
        private void ticketCancel(object sender, EventArgs e)
        {
            //Todo Bilet İptal
            if (expeditionListView.SelectedItems.Count > 0 && armchairListView.SelectedItems.Count > 0)
            {
                int itemnumber = armchairListView.SelectedItems[0].Index;
                if (armchairListView.Items[itemnumber].SubItems[3].Text == "Dolu" || armchairListView.Items[itemnumber].SubItems[3].Text == "Rezerve")
                {
                    string id = expeditionListView.SelectedItems[0].Text;
                    Node<Armchair> current = findArmchair(findExpedition(id));
                    current.Data.Name = "";
                    current.Data.Gender = "";
                    current.Data.State = "Boş";

                    printToTxtFile();
                    printToMyList(path);
                    //  printToArmchairListView(e.Item.Text);
                    
                    announcement.InfoLogger("Bilet iptal edildi!");
                }
                else
                {
                    MessageBox.Show("Silinecek olan koltuk dolu olmalıdır!");
                    announcement.WarnLogger("Kullanıcı dolu koltuğu silmek istedi!");
                }    
            }
            else
            {
                MessageBox.Show("Lütfen sefer ve koltuk seçiniz!");
            }
        }                             
        private void expeditionListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            printToArmchairListView(e.Item.Text);
           
        }
        public void expeditionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
