using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Signup(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up ss = new Sign_Up();
            ss.Show();
        }

        private void Button2_Login(object sender, EventArgs e)
        {
            this.Hide();
            mainpage ss = new mainpage();
            ss.Show();
        }

        private void Button4_Forgot(object sender, EventArgs e)
        {
            this.Hide();
            Forgot ss = new Forgot();
            ss.Show();
        }
    }
}
