﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class ImportForm : Form
    {
        public String FileName { set; get; }

        public ImportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileName = textBox1.Text;
            textBox1.DataBindings.Add("Text", this, "FileName");
            Close();
        }
    }
}
