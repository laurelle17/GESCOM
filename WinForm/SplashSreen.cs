﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class SplashSreen : Form
    {
        public SplashSreen()
        {
            InitializeComponent();
            timer1.Tick += timer2_Tick;
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Enabled = true;
            

        }

        private void SplashSreen_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Parent principal = new Parent();
            principal.Show();
            this.Close();
        }
    }
}
