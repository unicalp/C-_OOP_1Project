using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projekt1_Ates64504
{
    public partial class ProjektLaborotorim : Form
    {
        const int Margines = 10;
        const int PromienOA = 5;

        public float Xd;
        public float Xg;
        float h;

        Graphics Rysownica;
        int IndexPOA;
        int MaxIndexPOA;

        float[,] TWS;
        Pen PióroXY, PióroLiniiToru;
        static ProjektLaborotorim UchwytFormularza;
        int LiczbaPrzedziałów;

        const float DolnaGranicaPrzedzialu = float.MinValue;
        const float GórnaGranicaPrzedziału = float.MaxValue;

        public ProjektLaborotorim()
        {
            InitializeComponent();

            UchwytFormularza = this;

            ptrbRysownica.BackColor = Color.White;
            ptrbRysownica.BorderStyle = BorderStyle.Fixed3D;
            ptrbRysownica.Image = new Bitmap(ptrbRysownica.Width, ptrbRysownica.Height);

            Rysownica = Graphics.FromImage(ptrbRysownica.Image);

            PióroXY = new Pen(Color.Blue, 0.5F);
            PióroXY.StartCap = LineCap.Flat;
            PióroXY.EndCap = LineCap.ArrowAnchor;

            AdjustableArrowCap dużeGrotyStrzałek = new AdjustableArrowCap(3,5);
            PióroXY.StartCap = LineCap.Square;
            PióroXY.CustomEndCap = dużeGrotyStrzałek;
            PióroLiniiToru = new Pen(Color.Black, 1.5F);
            PióroLiniiToru.DashStyle = DashStyle.Dot;
        }

        static class PrzeliczanieWspółrzędnych
        {
            static float Sx, Sy;
            static float Dx, Dy;
            static int Xe_min, Xe_max;
            static int Ye_min, Ye_max;

            public static float Xmin
            {
                get;
                private set;
            }
            public static float Xmax
            {
                get;
                private set;
            }

            public static float Ymin
            {
                get;
                private set;
            }
            public static float Ymax
            {
                get;
                private set;
            }

            static PrzeliczanieWspółrzędnych()
            {
                Xmin = UchwytFormularza.Xd;
                Xmax = UchwytFormularza.Xg;
                Ymin = EkstremumSzeregu.MinSx(UchwytFormularza.TWS);
                Ymax = EkstremumSzeregu.MaxSx(UchwytFormularza.TWS);

                Xe_min = Margines;
                Xe_max = UchwytFormularza.ptrbRysownica.Width - (Margines + Margines);

                Ye_min = Margines;
                Ye_max = UchwytFormularza.ptrbRysownica.Height - (Margines + Margines);

                Sx = (Xe_max - Xe_min) / (Xmax - Xmin);
                Sy = (Ye_max - Ye_min) / (Ymax - Ymin);
                
                Dx = Xe_min - Xmin * Sx;
                Dy = Ye_min - Ymin * Sy;
            }

            public static int WspX(float X)
            {
                return (int)(X * Sx + Dx);
            }

            static public int WspY(float Y)
            {
                return (int)(Y * Sy + Dy);
            }
        }

        bool PobierzDaneWejsciowe(out float Xd, out float Xg, out float h)
        {
            Xd = Xg = h = 0.0F;

            if (!float.TryParse(txtXd.Text, out Xd))
            {
                errorProvider1.SetError(txtXd, "ERROR: w podanym zapisie wartośći Xd wystąpił niedoawolony znak");
                return false;
            }

            if ((Xd < DolnaGranicaPrzedzialu) || (Xd > GórnaGranicaPrzedziału))
            {
                errorProvider1.SetError(txtXd, "ERROR: podana wartośći Xd wykraca poza przadzial zbieżnosci szeregu ");
                return false;
            }

            if (!float.TryParse(txtXg.Text, out Xg))
            {
                errorProvider1.SetError(txtXg, "ERROR: w podanym zapisie wartośći Xg wystąpił niedoawolony znak");
                return false;
            }

            if ((Xg < DolnaGranicaPrzedzialu) || (Xg > GórnaGranicaPrzedziału))
            {
                errorProvider1.SetError(txtXg, "ERROR: podana wartośći Xg wykraca poza przadzial zbieżnosci szeregu ");
                return false;
            }

            if (Xd > Xg)
            {
                errorProvider1.SetError(txtXg, "ERROR: nie jest spełniony warunek nakłady na granice przedziału zmian wartosci zmiennej X: Xd < Xg");
                return false;
            }

            if (!float.TryParse(txtH.Text, out h))
            {
                errorProvider1.SetError(txtH, "ERROR: w podanym zapisie wartośći 'h' wystąpił niedoawolony znak");
                return false;
            }

            if ((h <= 0.0f) || (h >= 1.0f))
            {
                errorProvider1.SetError(txtH, "ERROR: podana wartosc przyristu 'h' nie spełnia warumku ejsciwego: 0 < h < 1.0");
                return false;
            }

            return true;
        }

        void TablicowanieSzeregu(float[,] TWS, float Xd, float Xg, float h)
        {
            float X;
            int i;

            for (X = Xd, i = 0; i < TWS.GetLength(0); X = Xd + i * h, i++)
            {
                TWS[i, 0] = X;
                TWS[i, 1] = ObliczenieWartosciSzeregu(X);
            }
        }

        private void btnAnimacja_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            if (!PobierzDaneWejsciowe(out Xd, out Xg, out h))
            {
                errorProvider1.SetError(txtXd, "ERROR: wystąpił niedozwolony znak w podanej wartości Xd");
                return;
            }

            LiczbaPrzedziałów = (int)((Xg - Xd) / h) + 1;
            TWS = new float[LiczbaPrzedziałów, 2];

            TablicowanieSzeregu(TWS, Xd, Xg, h);

            IndexPOA = 0;
            MaxIndexPOA = TWS.GetLength(0) - 1;
            timer1.Enabled = true;
        }

        private void ptrbRysownica_Paint(object sender, PaintEventArgs e)
        {
            if (TWS is null)
            {
                return;
            }

            Rysownica.Clear(Color.White);
            Rysownica.DrawLine(PióroXY, PrzeliczanieWspółrzędnych.WspX(0), PrzeliczanieWspółrzędnych.WspY(PrzeliczanieWspółrzędnych.Ymax), PrzeliczanieWspółrzędnych.WspX(0), PrzeliczanieWspółrzędnych.WspY(PrzeliczanieWspółrzędnych.Ymin));
            Rysownica.DrawLine(PióroXY, PrzeliczanieWspółrzędnych.WspX(PrzeliczanieWspółrzędnych.Xmin), PrzeliczanieWspółrzędnych.WspY(0), PrzeliczanieWspółrzędnych.WspX(PrzeliczanieWspółrzędnych.Xmax),  PrzeliczanieWspółrzędnych.WspY(0));

            for (int j = 0; j < TWS.GetLength(0) - 1; j++)
            {
                Rysownica.DrawLine(PióroLiniiToru, PrzeliczanieWspółrzędnych.WspX(TWS[j, 0]), PrzeliczanieWspółrzędnych.WspY(TWS[j, 1]), PrzeliczanieWspółrzędnych.WspX(TWS[j + 1, 0]), PrzeliczanieWspółrzędnych.WspY(TWS[j + 1, 1]));
            }

            Rysownica.FillEllipse(Brushes.Yellow, PrzeliczanieWspółrzędnych.WspX(TWS[IndexPOA, 0]) - PromienOA, PrzeliczanieWspółrzędnych.WspY(TWS[IndexPOA, 1]) - PromienOA, 2 * PromienOA, 2 * PromienOA);
        }

        float ObliczenieWartosciSzeregu(float X)
        {
            const float Eps = 0.00000001F;
            float w, S;
            int k;
            w = 1;
            k = 0;
            S = w;

            while (Math.Abs(w) > Eps)
            {
                k++;
                w = w * ((-1.0F) * X * X) / (float)(2 * k * (2 * k + 1));
                S = S + w;
            }

            return S;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kokpit_Ates64504 form1 = new Kokpit_Ates64504();
            form1.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IndexPOA >= MaxIndexPOA)
            {
                IndexPOA = 0;
            }
                
            else
            {
                IndexPOA++;
            }

            ptrbRysownica.Refresh();
        }

        private void ptrbRysownica_Click(object sender, EventArgs e)
        {

        }

        private void ProjektLaborotorim_Load(object sender, EventArgs e)
        {

        }

        private void Laboratory_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}