﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKirmizi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnMavi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnSari_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void btnYesil_Click(object sender, EventArgs e)
        {
            this.BackColor = btnYesil.BackColor;
            // Amacıma farklı şekilde ulaşmış olduk. Diğerlerinde
            // arkaplan rengini doğrudan değiştirirken bu butonda ise
            // buton arkaplan rengini doğrudan Form'un arkaplanına
            // aktarıyoruz..
        }
    }
}
