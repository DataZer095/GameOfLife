﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            if (timer.Enabled) 
                return;

            nudDensity.Enabled = false;
            nudResolution.Enabled = false;
            resolution = (int) nudResolution.Value;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
        }
       

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
            graphics.FillRectangle(Brushes.Crimson, 0, 0, resolution, resolution);
        }
        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
