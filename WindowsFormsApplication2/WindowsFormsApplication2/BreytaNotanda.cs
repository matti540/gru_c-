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
    public partial class BreytaNotanda : Form
    {
        adferdir adferd = new adferdir();
        string uid = null;
        public BreytaNotanda(string id)
        {
            InitializeComponent();
            adferd.TengingVidGagnagrunn();
            uid = id;
        }

        private void BreytaNotanda_Load(object sender, EventArgs e)
        {
            List<string> notandi = adferd.LesautSQLToflu("SELECT * FROM members WHERE id ='" + uid + "'");
            foreach (var n in notandi)
            {
                string[] konni = n.Split(':');
                tbNotandanafn.Text = konni[1].ToString();
                tbLykilord.Text = konni[2].ToString();
                cbrank.SelectedItem = konni[4];
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            string username = tbNotandanafn.Text;
            string password = tbLykilord.Text;
            string rank = cbrank.SelectedItem.ToString();
            if(username.Length > 0 && password.Length > 0 && (rank == "User" || rank == "Moderator" || rank == "Administrator"))
            {
              adferd.Uppfaera("UPDATE members SET username ='" + username + "', password ='" + password + "', rank = '" + rank + "' WHERE id = '" + uid + "'");
              MessageBox.Show("Notanda breytt.");
              this.Close();
            }
            else 
            {
                MessageBox.Show("Vinsamlegast fylltu alla kassana til að gera þessa breytingu gilda");
            }
          
        }
    }
}
