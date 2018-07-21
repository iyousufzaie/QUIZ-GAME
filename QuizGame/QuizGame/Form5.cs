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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Text = "Level 4";
            this.label1.Text = "Which is the most sensitive organ in our body?";
            this.label2.Text = "What is the symbol of copper?";
                this.label3.Text="What is 2*(5+9)?";
                this.label4.Text = "Who discovered gravity?";
            this.button1.Text="Okay";
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "skin" && textBox2.Text == "cu" && textBox3.Text == "28" && textBox4.Text == "newton")
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
