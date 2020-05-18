using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cell = textBox1.Text;
                List<string> val = new List<string>();
                for (int i = 0; i < cell.Length; i++)
                {
                    int a = getIndexofNumber(cell.Substring(i,1));
                    if (a > -1)
                    {
                        val.Add(cell.Substring(i,1));
                    }
                }
                textBox2.Text = string.Join("",val);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private int getIndexofNumber(string cell)
        {
            int a = -1, indexofNum = 10000;
            a = cell.IndexOf("0"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("1"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("2"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("3"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("4"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("5"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("6"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("7"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("8"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
            a = cell.IndexOf("9"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }

            if (indexofNum != 10000)
            { return indexofNum; }
            else
            { return -1; }


        }
    }
}
