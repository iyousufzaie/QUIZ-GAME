using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "Level 3";
            this.label1.Text = "Which is the longest river on earth?";
            this.label2.Text = "What is the standard taste of water?";
            this.label3.Text = "Which is the fastest animal on land?";
            this.button1.Text = "Okay";
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "nile" && textBox2.Text == "tasteless" && textBox3.Text == "tiger")
            {
                MessageBox.Show("Congratulations ! You have crossed level 3");
                this.Hide();
                Form5 f5 = new Form5();
                f5.Show();
            }
            else
            {
                MessageBox.Show("Your entered answers are wrong :(");
                this.Hide();
                Form7 f7 = new Form7();
                f7.Show();
            }
        }
    }
}
