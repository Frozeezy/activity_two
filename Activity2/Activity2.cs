using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wishlist.Items.Add("Shoes");
            Wishlist.Items.Add("T-shirt");
            Wishlist.Items.Add("Phone");
            Wishlist.Items.Add("Car");
            Wishlist.Items.Add("Bag");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Wishlist.Sorted = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wishlist.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            countBox.Text = Convert.ToString(Wishlist.Items.Count);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void Wishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Wishlist.Text;
        }
    }
}
