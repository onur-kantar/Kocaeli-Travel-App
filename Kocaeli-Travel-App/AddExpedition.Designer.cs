namespace Kocaeli_Travel_App
{
    partial class AddExpedition
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
            this.capacity = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.road = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.TextBox();
            this.captain = new System.Windows.Forms.ComboBox();
            this.licancePlate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(99, 129);
            this.capacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(128, 22);
            this.capacity.TabIndex = 4;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(99, 158);
            this.price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(128, 22);
            this.price.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Güzergah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Zaman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kapasite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ücret";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Plaka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kaptan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Id";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(99, 17);
            this.id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(128, 22);
            this.id.TabIndex = 0;
            // 
            // road
            // 
            this.road.FormattingEnabled = true;
            this.road.Items.AddRange(new object[] {
            "Kocaeli-Ankara",
            "Kocaeli-İstanbul",
            "Kocaeli-İzmir",
            "Ankara-Kocaeli",
            "İstanbul-Kocaeli",
            "İzmir-Kocaeli"});
            this.road.Location = new System.Drawing.Point(99, 44);
            this.road.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(128, 24);
            this.road.TabIndex = 1;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(99, 71);
            this.date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(128, 22);
            this.date.TabIndex = 2;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(99, 100);
            this.time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(128, 22);
            this.time.TabIndex = 3;
            // 
            // captain
            // 
            this.captain.FormattingEnabled = true;
            this.captain.Items.AddRange(new object[] {
            "Ramazan Furkan Çınar",
            "Onur Kantar",
            "Lütfü Sevinç",
            "Mert Yakar"});
            this.captain.Location = new System.Drawing.Point(99, 213);
            this.captain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.captain.Name = "captain";
            this.captain.Size = new System.Drawing.Size(128, 24);
            this.captain.TabIndex = 7;
            // 
            // licancePlate
            // 
            this.licancePlate.FormattingEnabled = true;
            this.licancePlate.Items.AddRange(new object[] {
            "41 BSM 3441",
            "41 ISE 9898"});
            this.licancePlate.Location = new System.Drawing.Point(99, 185);
            this.licancePlate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.licancePlate.Name = "licancePlate";
            this.licancePlate.Size = new System.Drawing.Size(128, 24);
            this.licancePlate.TabIndex = 6;
            // 
            // AddExpedition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 304);
            this.Controls.Add(this.licancePlate);
            this.Controls.Add(this.captain);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.road);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.capacity);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddExpedition";
            this.Text = "Add Expedition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox capacity;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ComboBox road;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.ComboBox captain;
        private System.Windows.Forms.ComboBox licancePlate;
    }
}