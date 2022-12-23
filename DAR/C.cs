﻿using DAR;
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
    public partial class C : Form
    {
        public C()
        {
            InitializeComponent();
        }

        private void IDC_NEXTC_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nextc.Text);
            GV.in_c[i, 0] = Int32.Parse(m_npc.Text);
            GV.in_c[i, 1] = Int32.Parse(m_nmc.Text);
            GV.mu_c[i] = Single.Parse(m_zc.Text);
            i++;
            m_nextc.Text = i.ToString();
            if (i <= GV.nc)
            {
                m_npc.Text = "0";
                m_nmc.Text = "0";
                m_zc.Text = "0";
                m_npc.Focus();
            }
            else
                Close();
        }

        private void C_Load(object sender, EventArgs e)
        {

        }
    }
}
