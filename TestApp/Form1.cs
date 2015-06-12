using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = var1TextBox.Text;
            List<string> values = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                int index = temp.IndexOf('/');
                values.Add(temp.Substring(0, index).Trim(' '));
                temp = temp.Remove(0, index + 1).Trim(' ');
            }
            values.Add(temp);
            foreach (var value in values)
            {
                outListBoxText.Items.Add(value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(var2TextBox.Text);
        }
    }
}
