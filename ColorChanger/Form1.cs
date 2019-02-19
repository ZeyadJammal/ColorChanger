using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text.Length > 2 )
            {
                var result = MessageBox.Show(" Change to " + textBox1.Text + " .", "Changeing Color",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                // this.BackColor = Green;  // this is my code then I thought I want to change the color 
                // to the name of color entered by user so i tried but didn't succeed then I searched google 
                // and find this code I understand it but i couldn't write it by myself
                // didn't validate the color
                this.BackColor = (Color)new ColorConverter().ConvertFromString(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
