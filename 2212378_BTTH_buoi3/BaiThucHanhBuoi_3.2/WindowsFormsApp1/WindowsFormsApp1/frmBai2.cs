﻿using System;
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
    public partial class btnchonhang : Form
    {
        public btnchonhang()
        {
            InitializeComponent();
        }

        private void btnchonhang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = ListBox1.SelectedItem;
            listBox2.Items.Add(item);
        }
    }
}
