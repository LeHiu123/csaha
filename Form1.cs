﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_thực_hành_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbNhap_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox1.Text.Trim());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.CheckedItems[0].Remove();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
