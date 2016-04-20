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
    public partial class Form2 : Form
    {
        adferdir adferd = new adferdir();
        public Form2()
        {
            adferd.TengingVidGagnagrunn();
            InitializeComponent();
        }

        string id = null;

        private void Form2_Load(object sender, EventArgs e)
        {
            listViewNotendur.Columns.Add("ID", 30);
            listViewNotendur.Columns.Add("Notandanafn", 150);
            listViewNotendur.Columns.Add("Lykilorð", 90);
            listViewNotendur.Columns.Add("Posts", 50);
            listViewNotendur.Columns.Add("Rank", 80);
            listViewNotendur.Columns.Add("Banned", 60);

            BirtaNotendur();
        }

        // Takki til að breyta upplýsingum um notanda.
        private void btBreytaUpplysingum_Click(object sender, EventArgs e)
        {
            // Athugar hvort einhver notandi sé valinn.
            if (listViewNotendur.SelectedItems.Count > 0)
            {
                BreytaNotanda breyta = new BreytaNotanda(id);
                breyta.Show();
            }
        }

        // Bannar notanda
        private void btBanna_Click(object sender, EventArgs e)
        {
            adferd.Uppfaera("UPDATE members SET banned = '1' WHERE id ='" + id + "'");
            BirtaNotendur();
        }

        // Afléttir banni á notanda
        private void btUnban_Click(object sender, EventArgs e)
        {
            adferd.Uppfaera("UPDATE members SET banned = '0' WHERE id ='" + id + "'");
            BirtaNotendur();
        }

        // Þegar notandi er valinn úr listanum.
        private void listViewNotendur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNotendur.SelectedItems.Count > 0)
            {
                // Röðin sem notandinn valdi í list viewinu.
                var row = listViewNotendur.SelectedItems[0];

                id = row.SubItems[0].Text;
            }
        }

        private void BirtaNotendur()
        {
            listViewNotendur.Items.Clear();

            List<string> notendur = adferd.LesautSQLToflu("SELECT * FROM members");
            foreach (var notandi in notendur)
            {
                string[] konni = notandi.Split(':');
                ListViewItem itm = new ListViewItem(konni);
                if (konni[5] == "1")
                {
                    itm.SubItems[4].BackColor = Color.Red;
                }
                else if (konni[4] == "Moderator")
                {
                    itm.SubItems[4].BackColor = Color.LightGreen;
                }
                else if (konni[4] == "Administrator")
                {
                    itm.SubItems[4].BackColor = ColorTranslator.FromHtml("#008ae6");
                }
                itm.UseItemStyleForSubItems = false;
                listViewNotendur.Items.Add(itm);
            }
        }
    }
}
