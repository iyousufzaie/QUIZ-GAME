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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Text = "Level 6";
            this.label1.Text = "What is the capital of Pakistan?";
            this.label2.Text = "Who is the creator of facebook?";
            this.label3.Text = "What is the currency of Saudia Arabia?";
            this.label4.Text = "Which is the largest continent of the world?";
            this.label6.Text = "What element is made when sodium reacts with chlorine?";
            this.button2.Text = "Okay";
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
            this.label6.BackColor = Color.Transparent;




        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "islamabad" && textBox2.Text == "mark zuckerberg" && textBox3.Text == "riyal" && textBox6.Text == "asia" && textBox7.Text == "nacl")
            {
                MessageBox.Show("Congratulations ! You have crossed level 4");
                this.Hide();
                Form6 f6 = new Form6();
                f6.Show();
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
