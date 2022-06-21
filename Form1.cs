using System;
using System.Windows.Forms;

namespace PasswordValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passwordLengthSelector.Value = passwordValidator1.PasswordLength;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordValidator1.Valid)
            {
                MessageBox.Show("Password is valid");
            }
            else
            {
                MessageBox.Show("Password is not valid");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            passwordValidator1.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            passwordValidator1.SpecialChars = textBox2.Text;
        }

        private void passwordLengthSelector_ValueChanged_1(object sender, EventArgs e)
        {
            passwordValidator1.PasswordLength = (int)passwordLengthSelector.Value;
        }
    }
}
