﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype2
{
    public partial class FormGrass : Form
    {
        public FormGrass()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculation newForm = new Calculation();
            newForm.Show();
        }
    }
}
