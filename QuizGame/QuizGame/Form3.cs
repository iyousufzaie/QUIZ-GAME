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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Level 2";
            this.button1.Text = "Okay";
            this.label1.Text = "What are the two holes in the nose called?";
            this.label2.Text = "Which is the principal source of energy for earth?";
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;

                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "nostrils" && textBox2.Text == "sun")
            {
                MessageBox.Show("Congratulations ! You have crossed level 2");
                this.Hide();
                Form4 f4 = new Form4();
                f4.Show();
            }
            else
            {
                MessageBox.Show("You entered a wrong answer :( ");
                this.Hide();
                Form7 f7 = new Form7();
                f7.Show();
            }
        }
    }
}
