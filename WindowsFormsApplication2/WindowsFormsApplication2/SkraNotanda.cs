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
    public partial class SkraNotanda : Form
    {
        adferdir adferd = new adferdir();

        public SkraNotanda()
        {
            adferd.TengingVidGagnagrunn();
            InitializeComponent();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            string notandanafn = tbNotandanafn.Text;
            string password = tbLykilorð.Text;
            string rank = cbNotandaRank.Text;
            if (notandanafn.Length > 0 && password.Length > 0 && (rank == "User" || rank == "Moderator" || rank == "Administrator"))
            {
                adferd.SettInnSqlToflu("INSERT INTO members (id, username, password, posts, rank) VALUES (DEFAULT, '" + notandanafn + "', '" + password + "', 0, '" + rank + "')");
                MessageBox.Show("Nýr aðgangur búinn til");
                this.Close();
            }
            else
            {
                MessageBox.Show("Vinsamlegast fylltu alla kassana til að gera þessa breytingu gilda");
            }
        }
    }
}
