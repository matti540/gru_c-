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

            BirtaNotendur("SELECT * FROM members");
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
            /*adferd.Uppfaera("UPDATE members SET banned = '1' WHERE id ='" + id + "'");
            BirtaNotendur("SELECT * FROM members");
            */
            if (listViewNotendur.SelectedItems.Count > 0)
            {
                // Athugar hvort valinn notandi sé Administrator
                if (listViewNotendur.SelectedItems[0].SubItems[4].Text != "Administrator")
                {
                    adferd.Uppfaera("UPDATE members SET banned = '1' WHERE id ='" + id + "'");
                    BirtaNotendur("SELECT * FROM members");
                }
                else
                {
                    MessageBox.Show("Ekki hægt að banna Administrator");
                }
            }
        }

        // Afléttir banni á notanda
        private void btUnban_Click(object sender, EventArgs e)
        {
            if (listViewNotendur.SelectedItems.Count > 0)
            {
                adferd.Uppfaera("UPDATE members SET banned = '0' WHERE id ='" + id + "'");
                BirtaNotendur("SELECT * FROM members");
            }
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


       // private void BirtaNotendur(string fyrirspurn)

        // Birtir alla notendur í töfluna.
        private void BirtaNotendur(string fyrirspurn)

        {
            listViewNotendur.Items.Clear();

            List<string> notendur = adferd.LesautSQLToflu(fyrirspurn);
            foreach (var notandi in notendur)
            {
                string[] konni = notandi.Split(':');
                ListViewItem itm = new ListViewItem(konni);
                if (konni[5] == "1")
                {
                    itm.SubItems[5].BackColor = Color.Black;
                    itm.SubItems[5].ForeColor = Color.White;
                }
                if (konni[4] == "Moderator")
                {
                    itm.SubItems[4].BackColor = ColorTranslator.FromHtml("#00e600");
                }
                else if (konni[4] == "Administrator")
                {
                    //itm.SubItems[4].BackColor = ColorTranslator.FromHtml("#008ae6");
                    itm.SubItems[4].BackColor = Color.Red;
                }
                itm.UseItemStyleForSubItems = false;
                listViewNotendur.Items.Add(itm);
            }
        }

        // Opnar form til að búa til nýjan notanda
        private void btSkraNyjanNotanda_Click(object sender, EventArgs e)
        {
            SkraNotanda skraningarform = new SkraNotanda();
            skraningarform.Show();
        }

        // Endurstillir notanda þ.e. eyðir öllum postum og þráðum sem hann á o.fl.
        private void btEndurstillaNotanda_Click(object sender, EventArgs e)
        {
            // Athugar hvort einhver notandi sé valinn
            if (listViewNotendur.SelectedItems.Count > 0)
            {
                // Athugar hvort notandinn sé ekki Administrator
                if (listViewNotendur.SelectedItems[0].SubItems[4].Text != "Administrator")
                {
                    string username = listViewNotendur.SelectedItems[0].SubItems[1].Text;
                    // Spyr hvort náunginn sé viss um að hann vilji endurstilla notandann.
                    if (MessageBox.Show("Ertu viss um að þú viljir endurstilla notandann: " + username + "?", "Endurstilla notanda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        adferd.Eyda("DELETE FROM posts WHERE posted_by = '" + id + "'");
                        adferd.Eyda("DELETE FROM threads WHERE creator_id = '" + id + "'");
                        adferd.Uppfaera("UPDATE members SET posts = '0' AND rank = 'User' WHERE id = '" + id + "'");
                        MessageBox.Show(username + " hefur verið endurstilltur");
                        BirtaNotendur("SELECT * FROM members");
                    }
                }
                else
                {
                    MessageBox.Show("Ekki hægt að endurstilla Admins");
                }
            }
        }

        // Leyfir notanda að nota sína eigin fyrirspurn til að birta notendur.
        private void btBirtaMedFyrirspurn_Click(object sender, EventArgs e)
        {
            lbBirtaMedFyrirspurn.Visible = !lbBirtaMedFyrirspurn.Visible;
            tbBirtaMedFyrirspurn.Visible = !tbBirtaMedFyrirspurn.Visible;
            buttonNotaEiginFyrirspurn.Visible = !buttonNotaEiginFyrirspurn.Visible;
        }

        // Birtir alla notendur.
        public void btBirtaNotendur_Click(object sender, EventArgs e)
        {
            BirtaNotendur("SELECT * FROM members");
        }

        // Keyrir fyrirspurn sem notandinn sló inn.
        private void buttonNotaEiginFyrirspurn_Click(object sender, EventArgs e)
        {
            if (tbBirtaMedFyrirspurn.Visible)
            {
                BirtaNotendur(tbBirtaMedFyrirspurn.Text);
                lbBirtaMedFyrirspurn.Visible = false;
                tbBirtaMedFyrirspurn.Visible = false;
                buttonNotaEiginFyrirspurn.Visible = false;
            }
        }
    }
}
