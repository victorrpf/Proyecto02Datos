﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto02Datos
{
    public partial class fmAcercade : Form
    {
        public fmAcercade()
        {
            InitializeComponent();
        }

        private void fmAcercade_Load(object sender, EventArgs e)
        {
            
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
