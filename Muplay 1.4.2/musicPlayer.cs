﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muplay_1._4._2
{
    public partial class musicPlayer : UserControl
    {
        public musicPlayer()
        {
            InitializeComponent();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            playBtn.BringToFront();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            pauseBtn.BringToFront();
        }
    }
}
