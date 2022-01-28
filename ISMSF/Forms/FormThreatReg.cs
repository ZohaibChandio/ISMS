using System;
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
    public partial class FormThreatReg : Form
    {
        public FormThreatReg()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            this.panel1.Controls.Add(f);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadform(new FormAddthreats());
        }
    }
}
