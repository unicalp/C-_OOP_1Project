using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Projekt1_Ates64504
{
    public partial class ProjectInduwydualny : Form
    {
        const int OBAMargines = 10;
        const int OBAPromienOA = 5;

        public float OBAXd;
        public float OBAXg;
        float OBAh;

        Graphics OBARysownica;
        int OBAIndexPOA;
        int OBAMaxIndexPOA;

        float[,] OBATWS;
        Pen OBAPióroXY, OBAPióroLiniiToru;
        static ProjectInduwydualny OBAUchwytFormularza;
        int OBALiczbaPrzedziałów;

        const float OBADgXd = float.MinValue;
        const float OBAGgXg = float.MaxValue;

        public ProjectInduwydualny()
        {
            InitializeComponent();

            OBAUchwytFormularza = this;

            OBAptrbRysownica.BorderStyle = BorderStyle.Fixed3D;
            OBAptrbRysownica.Image = new Bitmap(OBAptrbRysownica.Width, OBAptrbRysownica.Height);
            OBARysownica = Graphics.FromImage(OBAptrbRysownica.Image);

            OBAPióroXY = new Pen(Color.Blue, 0.5F);
            OBAPióroXY.StartCap = LineCap.Flat;
            OBAPióroXY.EndCap = LineCap.ArrowAnchor;

            AdjustableArrowCap OBAdużeGrotyStrzałek = new AdjustableArrowCap(3, 5);
            OBAPióroXY.StartCap = LineCap.Square;
            OBAPióroXY.CustomEndCap = OBAdużeGrotyStrzałek;
            OBAPióroLiniiToru = new Pen(Color.Black, 2F);
            OBAPióroLiniiToru.DashStyle = DashStyle.Solid;

            OBAdgvTWS.Visible = false;
            OBAchtWykresSzeregu.Visible = false;
            OBAptrbRysownica.Visible = false;
        }

        static class OBAPrzeliczanieWspółrzędnych
        {
            static float OBASx, OBASy;
            static float OBADx, OBADy;
            static int OBAXe_min, OBAXe_max;
            static int OBAYe_min, OBAYe_max;

            public static float OBAXmin
            {
                get;
                private set;
            }
            public static float OBAXmax
            {
                get;
                private set;
            }

            public static float OBAYmin
            {
                get;
                private set;
            }
            public static float OBAYmax
            {
                get;
                private set;
            }

            static OBAPrzeliczanieWspółrzędnych()
            {
                OBAXmin = OBAUchwytFormularza.OBAXd;
                OBAXmax = OBAUchwytFormularza.OBAXg;
                OBAYmin = EkstremumSzeregu.MinSx(OBAUchwytFormularza.OBATWS);
                OBAYmax = EkstremumSzeregu.MaxSx(OBAUchwytFormularza.OBATWS);

                OBAXe_min = OBAMargines;
                OBAXe_max = OBAUchwytFormularza.OBAptrbRysownica.Width - (OBAMargines + OBAMargines);
                OBAYe_min = OBAMargines;
                OBAYe_max = OBAUchwytFormularza.OBAptrbRysownica.Height - (OBAMargines + OBAMargines);

                OBASx = (OBAXe_max - OBAXe_min) / (OBAXmax - OBAXmin);
                OBASy = (OBAYe_max - OBAYe_min) / (OBAYmax - OBAYmin);

                OBADx = OBAXe_min - OBAXmin * OBASx;
                OBADy = OBAYe_min - OBAYmin * OBASy;
            }

            public static int OBAWspX(float OBAX)
            {
                return (int)(OBAX * OBASx + OBADx);
            }

            static public int OBAWspY(float OBAY)
            {
                return (int)(OBAY * OBASy + OBADy);
            }
        }

        private void Project_FormClosing(object sender, FormClosingEventArgs e)
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

        private void OBAbtnObliczSumeSzeregu_Click(object sender, EventArgs e)
        {
            OBAerrorProvider1.Dispose();
            float OBAX, OBAEps;

            if (!OBAPobranieDanychWejściowych_X_Eps(out OBAX, out OBAEps))
            {
                return;
            }

            float OBASuma;
            ushort OBALicznikWyrazów;
            //MessageBox.Show("Jestem przed wywołaniem metody ObliczWartośćSzeregu");
            OBASuma = OBAObliczWartośćSzeregu(OBAX, OBAEps, out OBALicznikWyrazów);
            //MessageBox.Show("Jestem po wywołaniem metody ObliczWartośćSzeregu");
            OBAtxtSuma.Text = OBASuma.ToString();
            OBAtxtLicznikWyrazuSzeregu.Text = OBALicznikWyrazów.ToString();
            OBAtxtX.Enabled = false;
        }

        bool OBAPobranieDanychWejściowych_X_Eps(out float OBAX, out float OBAEps)
        {
            OBAX = OBAEps = 0.0F;

            if (!float.TryParse(OBAtxtX.Text, out OBAX))
            {
                OBAerrorProvider1.SetError(OBAtxtX, "ERROR: w zapisie wartości zmiennej X wystąpil niedozwolony znak");
                return false;
            }

            if (!float.TryParse(OBAtxtEps.Text, out OBAEps))
            {
                OBAerrorProvider1.SetError(OBAtxtEps, "ERROR: w zapisie dokłsdności zmiennej Eps wystąpil niedozwolony znak");
                return false;
            }

            if ((OBAEps <= 0.0F) || (OBAEps >= 1.0F))
            {
                OBAerrorProvider1.SetError(OBAtxtEps, "ERROR: podana dokłsdności zmiennej Eps spełnia warunku wejściowego: 0.0 < Eps < 1.0");
                return false;
            }

            return true;
        }

        float OBAObliczWartośćSzeregu(float OBAX, float OBAEps, out ushort OBANumerWyrazu)
        {
            OBANumerWyrazu = 1;
            double OBASuma = 0.0F;
            double OBAw = 1.0F;
            do
            {
                OBASuma = OBASuma + OBAw;
                OBANumerWyrazu++;
                OBAw = (float)(OBAw * ((Math.Pow(OBAX, 2) + 2 * OBAX + 1) / OBANumerWyrazu));
            }

            while (Math.Abs(OBAw) > OBAEps);
            return (float)OBASuma;
        }

        private void OBAbtnWizualizacjaTabelaryczna_Click(object sender, EventArgs e)
        {
            OBAerrorProvider1.Dispose();
            float OBAEps, OBAXd, OBAXg, OBAh;
            if (!OBAPobranieDanychWejściowych_Eps_Xd_Xg_h(out OBAXd, out OBAXg, out OBAh, out OBAEps))
            {
                return;
            }

            //float[,] OBATWS;

            if (OBATWS is null)
            {
                OBATablicowanieWartościSzeregu(OBAXd, OBAXg, OBAh, OBAEps, out OBATWS);
            }

            OBAWpisanieDoKontrolkiDataGridViewTablicy(OBATWS, OBAdgvTWS);

            OBAdgvTWS.Visible = true;
            OBAchtWykresSzeregu.Visible = false;
            OBAptrbRysownica.Visible = false;
        }

        bool OBAPobranieDanychWejściowych_Eps_Xd_Xg_h(out float OBAXd, out float OBAXg, out float OBAh, out float OBAEps)
        {
            OBAXd = OBAXg = OBAh = OBAEps = 0.0F;
            if (!float.TryParse(OBAtxtXd.Text, out OBAXd))
            {
                OBAerrorProvider1.SetError(OBAtxtXd, "ERROR: wystąpił niedozwolony znak w zapisie danej Xd");
                return false;
            }

            if ((OBAXd < OBADgXd) || (OBAXd > OBAGgXg))
            {
                OBAerrorProvider1.SetError(OBAtxtXd, "ERROR: podana wartość Xd nie należy do przedziału zbiezności szeregu");
                return false;
            }

            if (!float.TryParse(OBAtxtXg.Text, out OBAXg))
            {
                OBAerrorProvider1.SetError(OBAtxtXg, "ERROR: wystąpił niedozwolony znak w zapisie danej Xg");
                return false;
            }

            if ((OBAXg < OBADgXd) || (OBAXg > OBAGgXg))
            {
                OBAerrorProvider1.SetError(OBAtxtXg, "ERROR: podana wartość Xg nie należy do przedziału zbiezności szeregu");
                return false;
            }

            if (OBAXg < OBAXd)
            {
                OBAerrorProvider1.SetError(OBAtxtXg, "ERROR: podana wartość Xg nie może być mniejsza od podaniej wartoszći Xd");
                return false;
            }

            if (!float.TryParse(OBAtxtH.Text, out OBAh))
            {
                OBAerrorProvider1.SetError(OBAtxtH, "ERROR: w zapisie przyrostu 'h' wystąpił niedozwolony znak");
                return false;
            }

            if (OBAh >= (OBAXg - OBAXd))
            {
                OBAerrorProvider1.SetError(OBAtxtH, "ERROR: wartość przyrostu 'h' nie może być większa od szerekości przedziału: (Xg - Xd)");
                return false;
            }

            OBAtxtH.Enabled = false;

            if (!float.TryParse(OBAtxtEps.Text, out OBAEps))
            {
                OBAerrorProvider1.SetError(OBAtxtEps, "ERROR: w zapisie dokładności obliczeń Eps wystąpił niedozwolony znak");
                return false;
            }

            if ((OBAEps <= 0.0F) || (OBAEps >= 1.0F))
            {
                OBAerrorProvider1.SetError(OBAtxtEps, "ERROR: podana wartość dokładbości obliczeń Eps nie spiłnia warunku wejściowego: 0.0 < Eps < 1.0");
                return false;
            }

            OBAtxtXg.Enabled = false;
            OBAtxtXd.Enabled = false;
            OBAtxtEps.Enabled = false;

            return true;
        }

        void OBATablicowanieWartościSzeregu(float OBAXd, float OBAXg, float OBAh, float OBAEps, out float[,] OBATWS)
        {
            int OBAn = (int)((OBAXg - OBAXd) / OBAh + 1);
            OBATWS = new float[OBAn + 1, 3];
            float OBAX;
            int OBAi;
            ushort OBALicznikZsumowanychWyrazów;

            for (OBAX = OBAXd, OBAi = 0; OBAi < OBATWS.GetLength(0); OBAi++, OBAX = OBAXd + OBAi * OBAh)
            {
                OBATWS[OBAi, 0] = OBAX;
                OBATWS[OBAi, 1] = OBAObliczWartośćSzeregu(OBAX, OBAEps, out OBALicznikZsumowanychWyrazów);
                OBATWS[OBAi, 2] = OBALicznikZsumowanychWyrazów;
            }
        }

        void OBAWpisanieDoKontrolkiDataGridViewTablicy(float[,] OBATWS, DataGridView OBAdgvTWS)
        {
            OBAdgvTWS.Rows.Clear();

            for (int OBAi = 0; OBAi < OBATWS.GetLength(0); OBAi++)
            {
                OBAdgvTWS.Rows.Add();
                OBAdgvTWS.Rows[OBAi].Cells[0].Value = string.Format("{0:0.00}", OBATWS[OBAi, 0]);
                OBAdgvTWS.Rows[OBAi].Cells[1].Value = string.Format("{0:0.000}", OBATWS[OBAi, 1]);
                OBAdgvTWS.Rows[OBAi].Cells[2].Value = string.Format("{0}", (int)OBATWS[OBAi, 2]);
            }
        }

        private void OBAbtnWizualizacjaGraficzna_Click(object sender, EventArgs e)
        {
            OBAerrorProvider1.Dispose();
            float OBAXd, OBAXg, OBAh, OBAEps;

            if (!OBAPobranieDanychWejściowych_Eps_Xd_Xg_h(out OBAXd, out OBAXg, out OBAh, out OBAEps))
            {
                return;
            }

            if (OBATWS is null)
            {
                OBATablicowanieWartościSzeregu(OBAXd, OBAXg, OBAh, OBAEps, out OBATWS);
            }

            OBAWpisanieWynikówDoKontrolkiChart(OBATWS, OBAchtWykresSzeregu);

            OBAdgvTWS.Visible = false;
            OBAchtWykresSzeregu.Visible = true;
            OBAptrbRysownica.Visible = false;
        }

        void OBAWpisanieWynikówDoKontrolkiChart(float[,] OBATWS, Chart OBAchtWykresSzeregu)
        {
            OBAchtWykresSzeregu.BorderlineWidth = 1;
            OBAchtWykresSzeregu.BorderlineColor = Color.Black;
            OBAchtWykresSzeregu.BorderlineDashStyle = ChartDashStyle.Solid;
            OBAchtWykresSzeregu.Titles.Add("Wykres zmian wartości szeregu S(X)");
            OBAchtWykresSzeregu.Legends.FindByName("Legend1").Docking = Docking.Bottom;
            OBAchtWykresSzeregu.BackColor = Color.White;
            OBAchtWykresSzeregu.ChartAreas[0].AxisX.Title = "Wartości X";
            OBAchtWykresSzeregu.ChartAreas[0].AxisY.Title = "Wartości S(X)";
            OBAchtWykresSzeregu.ChartAreas[0].AxisX.LabelStyle.Format = "{0:f2}";
            OBAchtWykresSzeregu.ChartAreas[0].AxisY.LabelStyle.Format = "{0:f2}";
            OBAchtWykresSzeregu.Series.Clear();
            OBAchtWykresSzeregu.Series.Add("Seria 0");
            OBAchtWykresSzeregu.Series[0].XValueMember = "X";
            OBAchtWykresSzeregu.Series[0].YValueMembers = "Y";
            OBAchtWykresSzeregu.Series[0].IsVisibleInLegend = true;
            OBAchtWykresSzeregu.Series[0].Name = "Wartość szeregu potęgowego S(X)";
            OBAchtWykresSzeregu.Series[0].ChartType = SeriesChartType.Line;
            OBAchtWykresSzeregu.Series[0].Color = Color.Black;
            OBAchtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.Solid;
            OBAchtWykresSzeregu.Series[0].BorderWidth = 1;

            for (int OBAi = 0; OBAi < OBATWS.GetLength(0); OBAi++)
            {
                OBAchtWykresSzeregu.Series[0].Points.AddXY(OBATWS[OBAi, 0], OBATWS[OBAi, 1]);
            }
        }

        private void OBAbtnResetuj_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectInduwydualny form3 = new ProjectInduwydualny();
            form3.Show();
        }

        private void OBAbtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kokpit_Ates64504 form1 = new Kokpit_Ates64504();
            form1.Show();
        }

        private void btnAnimacja_Click(object sender, EventArgs e)
        {
            OBAerrorProvider1.Dispose();

            //float OBAEps;
            if (!OBAPobranieDanychWejściowych_Eps_Xd_Xg_h(out OBAXd, out OBAXg, out OBAh, out float OBAEps))
            {
                OBAerrorProvider1.SetError(OBAtxtXd, "ERROR: wystąpił niedozwolony znak w podanej wartości Xd");
                return;
            }

            OBALiczbaPrzedziałów = (int)((OBAXg - OBAXd) / OBAh) + 1;
            OBATWS = new float[OBALiczbaPrzedziałów, 2];

            OBATablicowanieWartościSzeregu(OBAXd, OBAXg, OBAh, OBAEps, out OBATWS);

            OBAIndexPOA = 0;
            OBAMaxIndexPOA = OBATWS.GetLength(0) - 1;
            OBAtimer1.Enabled = true;

            OBAdgvTWS.Visible = false;
            OBAchtWykresSzeregu.Visible = false;
            OBAptrbRysownica.Visible = true;
        }

        private void OBAptrbRysownica_Paint(object sender, PaintEventArgs e)
        {
            if (OBATWS is null)
            {
                return;
            }

            OBARysownica.Clear(Color.White);
            OBARysownica.DrawLine(OBAPióroXY, OBAPrzeliczanieWspółrzędnych.OBAWspX(0), OBAPrzeliczanieWspółrzędnych.OBAWspY(OBAPrzeliczanieWspółrzędnych.OBAYmax), OBAPrzeliczanieWspółrzędnych.OBAWspX(0), OBAPrzeliczanieWspółrzędnych.OBAWspY(OBAPrzeliczanieWspółrzędnych.OBAYmin));
            OBARysownica.DrawLine(OBAPióroXY, OBAPrzeliczanieWspółrzędnych.OBAWspX(OBAPrzeliczanieWspółrzędnych.OBAXmin), OBAPrzeliczanieWspółrzędnych.OBAWspY(0), OBAPrzeliczanieWspółrzędnych.OBAWspX(OBAPrzeliczanieWspółrzędnych.OBAXmax), OBAPrzeliczanieWspółrzędnych.OBAWspY(0));

            for (int OBAj = 0; OBAj < OBATWS.GetLength(0) - 1; OBAj++)
            {
                OBARysownica.DrawLine(OBAPióroLiniiToru, OBAPrzeliczanieWspółrzędnych.OBAWspX(OBATWS[OBAj, 0]), OBAPrzeliczanieWspółrzędnych.OBAWspY(OBATWS[OBAj, 1]), OBAPrzeliczanieWspółrzędnych.OBAWspX(OBATWS[OBAj + 1, 0]), OBAPrzeliczanieWspółrzędnych.OBAWspY(OBATWS[OBAj + 1, 1]));
            }

            OBARysownica.FillEllipse(Brushes.Yellow, OBAPrzeliczanieWspółrzędnych.OBAWspX(OBATWS[OBAIndexPOA, 0]) - OBAPromienOA, OBAPrzeliczanieWspółrzędnych.OBAWspY(OBATWS[OBAIndexPOA, 1]) - OBAPromienOA, 2 * OBAPromienOA, 2 * OBAPromienOA);
        }

        private void OBAtimer1_Tick(object sender, EventArgs e)
        {
            if (OBAIndexPOA >= OBAMaxIndexPOA)
            {
                OBAIndexPOA = 0;
            }

            else
            {
                OBAIndexPOA++;
            }

            OBAptrbRysownica.Refresh();
        }

        private void OBAptrbRysownica_Click(object sender, EventArgs e)
        {

        }

        private void ProjectInduwydualny_Load(object sender, EventArgs e)
        {

        }

        private void OBAbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}