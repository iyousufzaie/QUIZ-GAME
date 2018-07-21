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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Level 1";
            this.label1.Text = "Which is the animal referred as the ship of the desert?";
            this.button1.Text = "Okay";
            this.label1.BackColor = Color.Transparent;

    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "camel")
            {
                MessageBox.Show("Congratulations ! You have crossed level 1");
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
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
