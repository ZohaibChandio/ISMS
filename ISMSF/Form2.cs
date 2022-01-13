using ISMSF.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMSF
{
    public partial class Form2 : Form
    {
        private Form activeForm;
        public Form2()
        {
            InitializeComponent();
        }

     

        public void loadform(object Form)
        {
            if (this.panelDesktoppannel.Controls.Count > 0)
                this.panelDesktoppannel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelDesktoppannel.Controls.Add(f);
            this.panelDesktoppannel.Tag = f;
            f.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            loadform(new FormAdmin());
        }
    }
}
