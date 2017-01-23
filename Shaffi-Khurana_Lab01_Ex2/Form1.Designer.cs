namespace Shaffi_Khurana_Lab01_Ex2
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textpostal = new System.Windows.Forms.TextBox();
            this.textprovince = new System.Windows.Forms.TextBox();
            this.textphone = new System.Windows.Forms.TextBox();
            this.retrieveInput = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Postal Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Province:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(119, 29);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 6;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(119, 54);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 20);
            this.textAddress.TabIndex = 7;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(119, 83);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(100, 20);
            this.textCity.TabIndex = 8;
            // 
            // textpostal
            // 
            this.textpostal.Location = new System.Drawing.Point(119, 113);
            this.textpostal.Name = "textpostal";
            this.textpostal.Size = new System.Drawing.Size(100, 20);
            this.textpostal.TabIndex = 9;
            // 
            // textprovince
            // 
            this.textprovince.Location = new System.Drawing.Point(119, 139);
            this.textprovince.Name = "textprovince";
            this.textprovince.Size = new System.Drawing.Size(100, 20);
            this.textprovince.TabIndex = 10;
            // 
            // textphone
            // 
            this.textphone.Location = new System.Drawing.Point(119, 166);
            this.textphone.Name = "textphone";
            this.textphone.Size = new System.Drawing.Size(100, 20);
            this.textphone.TabIndex = 11;
            // 
            // retrieveInput
            // 
            this.retrieveInput.Location = new System.Drawing.Point(27, 224);
            this.retrieveInput.Name = "retrieveInput";
            this.retrieveInput.Size = new System.Drawing.Size(75, 23);
            this.retrieveInput.TabIndex = 12;
            this.retrieveInput.Text = "Retrieve";
            this.retrieveInput.UseVisualStyleBackColor = true;
            this.retrieveInput.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(379, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Computer Analyst";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(532, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Computer Programmer";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listViewItem2.Tag = "Software Engineering";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(389, 113);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(27, 262);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(612, 96);
            this.inputText.TabIndex = 17;
            this.inputText.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(389, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 385);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.retrieveInput);
            this.Controls.Add(this.textphone);
            this.Controls.Add(this.textprovince);
            this.Controls.Add(this.textpostal);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textpostal;
        private System.Windows.Forms.TextBox textprovince;
        private System.Windows.Forms.TextBox textphone;
        private System.Windows.Forms.Button retrieveInput;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

