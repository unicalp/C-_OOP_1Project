using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1_Ates64504
{
    public partial class Kokpit_Ates64504 : Form
    {
        public Kokpit_Ates64504()
        {
            InitializeComponent();
        }

        private void btnLaboratory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjektLaborotorim form2 = new ProjektLaborotorim();
            form2.Show();
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectInduwydualny form3 = new ProjectInduwydualny();
            form3.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult OknoMassage = MessageBox.Show("Samoocena Sprawdzianu Nr 1 = 4.5, gdyż zostały zrealizowane" +
             " 4 z 5 zadań sprawdzianu Autor programu: OSMAN BERKE ATES: 64504", this.Text, MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (OknoMassage == DialogResult.Yes)
            {
                foreach (Form Formularz in Application.OpenForms)
                    //sprawdzenie, czy to jest formularz ProjektNr1
                    if (Formularz.Name == "Główny_formularz")
                    {
                        this.Hide();
                        //Otworzenie formularza znalezionego
                        Formularz.Show();
                        //bezwarunkowe zakonczenie obslugi zdarzenia click
                        return;
                    }
            }
            else
                e.Cancel = true;


        }

        private void Kokpit_Ates64504_Load(object sender, EventArgs e)
        {

        }

    }
}