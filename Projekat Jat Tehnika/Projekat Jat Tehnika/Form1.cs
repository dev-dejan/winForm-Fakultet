using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Projekat_Jat_Tehnika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jatDataSet.Radnik' table. You can move, or remove it, as needed.
            this.radnikTableAdapter.Fill(this.jatDataSet.Radnik);
            // TODO: This line of code loads data into the 'jatDataSet.Odrzavanje' table. You can move, or remove it, as needed.
            this.odrzavanjeTableAdapter.Fill(this.jatDataSet.Odrzavanje);
            // TODO: This line of code loads data into the 'jatDataSet.Nabavka' table. You can move, or remove it, as needed.
            this.nabavkaTableAdapter.Fill(this.jatDataSet.Nabavka);
            // TODO: This line of code loads data into the 'jatDataSet.Hangar' table. You can move, or remove it, as needed.
            this.hangarTableAdapter.Fill(this.jatDataSet.Hangar);
            // TODO: This line of code loads data into the 'jatDataSet.Avion' table. You can move, or remove it, as needed.
            this.avionTableAdapter.Fill(this.jatDataSet.Avion);
            brojaviona();
            brojAvionaizSrbije();
        }

        public void brojaviona()
        {
            int ukupno = 0;
            SqlConnection konekcija = new SqlConnection(Konekcija.konStr);
            SqlCommand komanda = new SqlCommand("SELECT AvionID FROM Avion", konekcija);

            try
            {
                konekcija.Open();
                SqlDataReader reader = komanda.ExecuteReader();
                while (reader.Read())
                {
                    ukupno++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
            tbBrAv.Text = ukupno.ToString();
        }

        public void brojAvionaizSrbije()
        {
            int ukupno = 0;
            SqlConnection konekcija = new SqlConnection(Konekcija.konStr);
            SqlCommand komanda = new SqlCommand("SELECT AvionID FROM Avion WHERE Drzava='Srbija' ", konekcija);

            try
            {
                konekcija.Open();
                SqlDataReader reader = komanda.ExecuteReader();
                while (reader.Read())
                {
                    ukupno++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
            tbAvSrb.Text = ukupno.ToString();
        }

        private void Osvezi()
        {
            SqlConnection konekcija = new SqlConnection(Konekcija.konStr);
            konekcija.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Avion", konekcija);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            brojaviona();
            konekcija.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            listBox1.Items.Clear();
            foreach (DataGridViewColumn kolona in dataGridView1.Columns)
                listBox1.Items.Add(dataGridView1.CurrentRow.Cells[kolona.Name].FormattedValue);
        }

        private void izbrisiAvionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBrisanje.Text))
            {
                MessageBox.Show("Morate upisati ID");
            }

            else
            {
                if (MessageBox.Show("Da li zelite da potvrdite brisanje", "Pitanje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection konekcija = new SqlConnection(Konekcija.konStr);
                    SqlCommand komanda = new SqlCommand("DELETE FROM Avion WHERE AvionID = '" + tbBrisanje.Text + "'", konekcija);
                    try
                    {
                        konekcija.Open();
                        komanda.ExecuteNonQuery();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {
                        konekcija.Close();
                    }
                    Osvezi();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            avionTableAdapter.Update(jatDataSet.Avion);
            Osvezi();
        }

        private void unesiNoviAvionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unos_novog_aviona un = new Unos_novog_aviona();
            if (un.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.avionTableAdapter.Insert(un.AvionID, un.Ime_Aviona, un.Drzava, un.Broj_Popravki, un.RadnikID, un.HangarID, un.NabavkaID, un.OdrazavanjeID);
                    this.avionTableAdapter.Fill(this.jatDataSet.Avion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
    }
}
