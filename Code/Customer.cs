﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        Connections conn = new Connections();
        private void Customer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.XemDL("SELECT * from khachhang");
        }
    }
}
