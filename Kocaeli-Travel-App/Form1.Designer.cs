namespace Kocaeli_Travel_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.armchairListView = new System.Windows.Forms.ListView();
            this.expeditionListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.asdasd = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ExpeditionCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tüm Sefer Sayısı :";
            // 
            // armchairListView
            // 
            this.armchairListView.FullRowSelect = true;
            this.armchairListView.GridLines = true;
            this.armchairListView.HideSelection = false;
            this.armchairListView.Location = new System.Drawing.Point(11, 276);
            this.armchairListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.armchairListView.Name = "armchairListView";
            this.armchairListView.Size = new System.Drawing.Size(803, 158);
            this.armchairListView.TabIndex = 13;
            this.armchairListView.UseCompatibleStateImageBehavior = false;
            this.armchairListView.View = System.Windows.Forms.View.Details;
            // 
            // expeditionListView
            // 
            this.expeditionListView.FullRowSelect = true;
            this.expeditionListView.GridLines = true;
            this.expeditionListView.HideSelection = false;
            this.expeditionListView.Location = new System.Drawing.Point(12, 95);
            this.expeditionListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expeditionListView.Name = "expeditionListView";
            this.expeditionListView.Size = new System.Drawing.Size(803, 158);
            this.expeditionListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.expeditionListView.TabIndex = 12;
            this.expeditionListView.UseCompatibleStateImageBehavior = false;
            this.expeditionListView.View = System.Windows.Forms.View.Details;
            this.expeditionListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.expeditionListView_ItemSelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seferler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Koltuklar";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(336, 12);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 50);
            this.button5.TabIndex = 9;
            this.button5.Text = " Gün Seç";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.selectDate);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 50);
            this.button4.TabIndex = 8;
            this.button4.Text = "Gelir Hesapla";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.calculateIncome);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Kaptan Değiştir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.captainChange);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.delete);
            // 
            // asdasd
            // 
            this.asdasd.Location = new System.Drawing.Point(12, 12);
            this.asdasd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.asdasd.Name = "asdasd";
            this.asdasd.Size = new System.Drawing.Size(75, 50);
            this.asdasd.TabIndex = 5;
            this.asdasd.Text = "Ekle";
            this.asdasd.UseVisualStyleBackColor = true;
            this.asdasd.Click += new System.EventHandler(this.add);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(499, 12);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 50);
            this.button7.TabIndex = 19;
            this.button7.Text = "Satış İptal";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ticketCancel);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(417, 12);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 50);
            this.button6.TabIndex = 14;
            this.button6.Text = "Satın Al";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ticketBuy);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ExpeditionCounter
            // 
            this.ExpeditionCounter.AutoSize = true;
            this.ExpeditionCounter.Location = new System.Drawing.Point(757, 75);
            this.ExpeditionCounter.Name = "ExpeditionCounter";
            this.ExpeditionCounter.Size = new System.Drawing.Size(16, 17);
            this.ExpeditionCounter.TabIndex = 15;
            this.ExpeditionCounter.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 443);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.ExpeditionCounter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.armchairListView);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.asdasd);
            this.Controls.Add(this.expeditionListView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Kocaeli Travel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button asdasd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView expeditionListView;
        private System.Windows.Forms.ListView armchairListView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label ExpeditionCounter;
    }
}

