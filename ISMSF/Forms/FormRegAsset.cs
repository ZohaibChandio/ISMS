﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMSF.Forms
{
    public partial class FormRegAsset : Form
    {
        private object panelDesktoppannel;

        public FormRegAsset()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
               
              
            FormPeopleReg f = new FormPeopleReg();
            f.Show();


        }
    }
}
