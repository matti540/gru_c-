﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        adferdir adferd = new adferdir();
        public Form1()
        {
            InitializeComponent();
            adferd.TengingVidGagnagrunn();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Takki til að skrá sig inn.
        private void signin_Click(object sender, EventArgs e)
        {
            List<string> list = adferd.LesautSQLToflu("SELECT * FROM members WHERE username = '" + username + "' AND password = '" + password + "'");
            MessageBox.Show(list.Count().ToString());
        }
    }
}
