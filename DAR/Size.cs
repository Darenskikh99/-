using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAR
{
    public partial class Size : Form
    {
        public Size()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            GV.nv = Int32.Parse(m_nv.Text);
            GV.nr = Int32.Parse(m_nr.Text);
            GV.nc = Int32.Parse(m_nc.Text);
            GV.nl = Int32.Parse(m_nl.Text);

            this.Close();
        }
    }
}
