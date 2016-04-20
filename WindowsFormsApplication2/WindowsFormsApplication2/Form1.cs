using System;
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
            List<string> list = adferd.LesautSQLToflu("SELECT * FROM members WHERE username = '" + username.Text + "' AND password = '" + password.Text + "'");
            if (list.Count() > 0)
            {
                string[] upplysingar = list[0].Split(':');
                if (upplysingar[4] == "Moderator" || upplysingar[4] == "Administrator")
                {
                    if (upplysingar[5] == "0" || upplysingar[4] == "Administrator")
                    {
                        Form2 form = new Form2();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("BANNED");
                    }
                }
                else 
                {
                    MessageBox.Show("Notandi þarf að vera Moderator eða Administrator til að komast inn.");
                }
            }
            else
            {
                MessageBox.Show("notandi fannst ekki, Reyndu aftur");
            }
        }
    }
}
