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
            string temp = "1507-B-A2-2-010 / Standardkurs A2.2 / 13.07.2015 / Mon/Die/Mit/Don/Fre 08:30-12:45";
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
                MessageBox.Show(value);
            }
        }
    }
}
