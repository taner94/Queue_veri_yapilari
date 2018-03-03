using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PriorityQueue pQ = new PriorityQueue(5);
            pQ.Insert(1);
            pQ.Insert(5);
            pQ.Insert(2);
            pQ.Insert(6);
            pQ.Insert(3);

            string temp = "";
            while (!pQ.IsEmpty())
            {
                temp += pQ.Remove().ToString() + "\n";
            }
            MessageBox.Show(temp);
        }
    }
}
