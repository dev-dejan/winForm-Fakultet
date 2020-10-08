using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_Jat_Tehnika
{
    public partial class Unos_novog_aviona : Form
    {

        public int AvionID { get { return Convert.ToInt32(tbAvion.Text); } }
        public string Ime_Aviona { get { return tbIme.Text; } }
        public string Drzava { get { return tbDrzava.Text; } }
        public int Broj_Popravki { get { return Convert.ToInt32(tbPopravke.Text); } }
        public int RadnikID { get { return Convert.ToInt32(tbRadnik.Text); } }
        public int HangarID { get { return Convert.ToInt32(tbHangar.Text); } }
        public int NabavkaID { get { return Convert.ToInt32(tbNabavka.Text); } }
        public int OdrazavanjeID { get { return Convert.ToInt32(tbOdrzavanje.Text); } }

        public Unos_novog_aviona()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (tbAvion.Text != "" && tbIme.Text != "" && tbDrzava.Text != "" && tbPopravke.Text != "" && tbRadnik.Text != "" && tbHangar.Text != "" && tbNabavka.Text != "" && tbOdrzavanje.Text != "")
            {

                DialogResult = DialogResult.OK;


            }
            else
            {
                MessageBox.Show("Niste uneli podatke");
                tbAvion.Text = tbIme.Text = tbDrzava.Text = tbPopravke.Text = tbRadnik.Text = tbHangar.Text = tbNabavka.Text = tbOdrzavanje.Text = "";
                tbAvion.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbAvion.Text = tbIme.Text = tbDrzava.Text = tbPopravke.Text = tbRadnik.Text = tbHangar.Text = tbNabavka.Text = tbOdrzavanje.Text = "";
        }
    }
}
