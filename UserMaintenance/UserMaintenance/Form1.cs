﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        List<Tick> ticks;
        PortfolioEntities context = new PortfolioEntities();
        public Form1()
        {
            InitializeComponent();

            ticks = context.Tick.ToList();
            dataGridView1.DataSource = ticks;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
