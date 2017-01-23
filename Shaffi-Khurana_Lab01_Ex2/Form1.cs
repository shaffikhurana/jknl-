using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaffi_Khurana_Lab01_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Items.Remove("C#");
                comboBox1.Items.Remove("Java");
                comboBox1.Items.Remove("Web Programming");
                comboBox1.Items.Add("Python");
                comboBox1.Items.Add("Database");
                comboBox1.Items.Add("Unix/Linux");
            }
            else
            {
                comboBox1.Items.Remove("Python");
                comboBox1.Items.Remove("Database");
                comboBox1.Items.Remove("Unix/Linux");
                comboBox1.Items.Add("C#");
                comboBox1.Items.Add("Java");
                comboBox1.Items.Add("Web Programming");

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String name = textName.Text;
            String address = textAddress.Text;
            String city = textCity.Text;
            String postal  = textpostal.Text;
            String province = textprovince.Text;
            String phone = textphone.Text;

            inputText.Text = (name + " " + address + city +postal +province +phone ).ToString();
        }
    }
}