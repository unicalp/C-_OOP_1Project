namespace Projekt1_Ates64504
{
    partial class ProjectInduwydualny
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.OBAdgvTWS = new System.Windows.Forms.DataGridView();
            this.MYWartośćX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MYWartośćSzeregu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MYLicznikWyrazów = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MYbtnResetuj = new System.Windows.Forms.Button();
            this.MYbtnWizualizacjaGraficzna = new System.Windows.Forms.Button();
            this.MYbtnWizualizacjaTabelaryczna = new System.Windows.Forms.Button();
            this.OBAtxtH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OBAtxtXg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OBAtxtXd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OBAtxtEps = new System.Windows.Forms.TextBox();
            this.OBAtxtX = new System.Windows.Forms.TextBox();
            this.OBAtxtSuma = new System.Windows.Forms.TextBox();
            this.MYbtnObliczSumeSzeregu = new System.Windows.Forms.Button();
            this.MYbtnExit = new System.Windows.Forms.Button();
            this.OBAtxtLicznikWyrazuSzeregu = new System.Windows.Forms.TextBox();
            this.MYbtnBack = new System.Windows.Forms.Button();
            this.OBAchtWykresSzeregu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OBAerrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.OBAptrbRysownica = new System.Windows.Forms.PictureBox();
            this.btnAnimacja = new System.Windows.Forms.Button();
            this.OBAtimer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OBAdgvTWS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBAchtWykresSzeregu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBAerrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBAptrbRysownica)).BeginInit();
            this.SuspendLayout();
            // 
            // OBAdgvTWS
            // 
            this.OBAdgvTWS.BackgroundColor = System.Drawing.Color.White;
            this.OBAdgvTWS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OBAdgvTWS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MYWartośćX,
            this.MYWartośćSzeregu,
            this.MYLicznikWyrazów});
            this.OBAdgvTWS.Location = new System.Drawing.Point(261, 21);
            this.OBAdgvTWS.Name = "OBAdgvTWS";
            this.OBAdgvTWS.RowHeadersWidth = 51;
            this.OBAdgvTWS.RowTemplate.Height = 24;
            this.OBAdgvTWS.Size = new System.Drawing.Size(622, 622);
            this.OBAdgvTWS.TabIndex = 67;
            // 
            // MYWartośćX
            // 
            this.MYWartośćX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MYWartośćX.DefaultCellStyle = dataGridViewCellStyle1;
            this.MYWartośćX.HeaderText = "Wartość zmiennej niezależnej X";
            this.MYWartośćX.MinimumWidth = 6;
            this.MYWartośćX.Name = "MYWartośćX";
            // 
            // MYWartośćSzeregu
            // 
            this.MYWartośćSzeregu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MYWartośćSzeregu.DefaultCellStyle = dataGridViewCellStyle2;
            this.MYWartośćSzeregu.HeaderText = "Wartość szeregu dla X";
            this.MYWartośćSzeregu.MinimumWidth = 6;
            this.MYWartośćSzeregu.Name = "MYWartośćSzeregu";
            // 
            // MYLicznikWyrazów
            // 
            this.MYLicznikWyrazów.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MYLicznikWyrazów.DefaultCellStyle = dataGridViewCellStyle3;
            this.MYLicznikWyrazów.HeaderText = "Licznik zsumowanych wyrazów";
            this.MYLicznikWyrazów.MinimumWidth = 6;
            this.MYLicznikWyrazów.Name = "MYLicznikWyrazów";
            // 
            // MYbtnResetuj
            // 
            this.MYbtnResetuj.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MYbtnResetuj.Location = new System.Drawing.Point(899, 567);
            this.MYbtnResetuj.Name = "MYbtnResetuj";
            this.MYbtnResetuj.Size = new System.Drawing.Size(236, 64);
            this.MYbtnResetuj.TabIndex = 66;
            this.MYbtnResetuj.Text = "RESETUJ (ustal\r\nstan początkowy)";
            this.MYbtnResetuj.UseVisualStyleBackColor = true;
            this.MYbtnResetuj.Click += new System.EventHandler(this.OBAbtnResetuj_Click);
            // 
            // MYbtnWizualizacjaGraficzna
            // 
            this.MYbtnWizualizacjaGraficzna.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MYbtnWizualizacjaGraficzna.Location = new System.Drawing.Point(899, 373);
            this.MYbtnWizualizacjaGraficzna.Name = "MYbtnWizualizacjaGraficzna";
            this.MYbtnWizualizacjaGraficzna.Size = new System.Drawing.Size(236, 91);
            this.MYbtnWizualizacjaGraficzna.TabIndex = 65;
            this.MYbtnWizualizacjaGraficzna.Text = "Graficzna wizualizacja zmian wartości szeregu potęgowego";
            this.MYbtnWizualizacjaGraficzna.UseVisualStyleBackColor = true;
            this.MYbtnWizualizacjaGraficzna.Click += new System.EventHandler(this.OBAbtnWizualizacjaGraficzna_Click);
            // 
            // MYbtnWizualizacjaTabelaryczna
            // 
            this.MYbtnWizualizacjaTabelaryczna.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MYbtnWizualizacjaTabelaryczna.Location = new System.Drawing.Point(899, 276);
            this.MYbtnWizualizacjaTabelaryczna.Name = "MYbtnWizualizacjaTabelaryczna";
            this.MYbtnWizualizacjaTabelaryczna.Size = new System.Drawing.Size(236, 91);
            this.MYbtnWizualizacjaTabelaryczna.TabIndex = 64;
            this.MYbtnWizualizacjaTabelaryczna.Text = "Tabelaryczna wizualizacja zmian wartości szeregu potęgowego";
            this.MYbtnWizualizacjaTabelaryczna.UseVisualStyleBackColor = true;
            this.MYbtnWizualizacjaTabelaryczna.Click += new System.EventHandler(this.OBAbtnWizualizacjaTabelaryczna_Click);
            // 
            // OBAtxtH
            // 
            this.OBAtxtH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OBAtxtH.Location = new System.Drawing.Point(17, 469);
            this.OBAtxtH.Name = "OBAtxtH";
            this.OBAtxtH.Size = new System.Drawing.Size(236, 34);
            this.OBAtxtH.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 52);
            this.label8.TabIndex = 62;
            this.label8.Text = "Przyrost h (zmian\r\nwartości zmiennej X)";
            // 
            // OBAtxtXg
            // 
            this.OBAtxtXg.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OBAtxtXg.Location = new System.Drawing.Point(17, 377);
            this.OBAtxtXg.Name = "OBAtxtXg";
            this.OBAtxtXg.Size = new System.Drawing.Size(236, 34);
            this.OBAtxtXg.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 52);
            this.label7.TabIndex = 60;
            this.label7.Text = "Górna granica przedziału\r\nXg (zmian wartości X)";
            // 
            // OBAtxtXd
            // 
            this.OBAtxtXd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OBAtxtXd.Location = new System.Drawing.Point(17, 285);
            this.OBAtxtXd.Name = "OBAtxtXd";
            this.OBAtxtXd.Size = new System.Drawing.Size(236, 34);
            this.OBAtxtXd.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 52);
            this.label6.TabIndex = 58;
            this.label6.Text = "Dolna granica przedziału\r\nXd (zmian wartości X)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(895, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 52);
            this.label5.TabIndex = 57;
            this.label5.Text = "Liczba zsumowanych\r\nwyrazów szeregu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(895, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 52);
            this.label4.TabIndex = 56;
            this.label4.Text = "Obliczona suma\r\nszeregu potęgowego";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 52);
            this.label3.TabIndex = 55;
            this.label3.Text = "Dokładność oblicznia\r\nsumy szeregu Eps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 52);
            this.label2.TabIndex = 54;
            this.label2.Text = "Wartość zmiennej\r\nniezalieżnej X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(304, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 53;
            // 
            // OBAtxtEps
            // 
            this.OBAtxtEps.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OBAtxtEps.Location = new System.Drawing.Point(17, 193);
            this.OBAtxtEps.Name = "OBAtxtEps";
            this.OBAtxtEps.Size = new System.Drawing.Size(236, 34);
            this.OBAtxtEps.TabIndex = 52;
            // 
            // OBAtxtX
            // 
            this.OBAtxtX.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OBAtxtX.Location = new System.Drawing.Point(17, 101);
            this.OBAtxtX.Name = "OBAtxtX";
            this.OBAtxtX.Size = new System.Drawing.Size(236, 34);
            this.OBAtxtX.TabIndex = 51;
            // 
            // OBAtxtSuma
            // 
            this.OBAtxtSuma.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OBAtxtSuma.Location = new System.Drawing.Point(899, 104);
            this.OBAtxtSuma.Name = "OBAtxtSuma";
            this.OBAtxtSuma.ReadOnly = true;
            this.OBAtxtSuma.Size = new System.Drawing.Size(236, 34);
            this.OBAtxtSuma.TabIndex = 49;
            // 
            // MYbtnObliczSumeSzeregu
            // 
            this.MYbtnObliczSumeSzeregu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MYbtnObliczSumeSzeregu.Location = new System.Drawing.Point(899, 236);
            this.MYbtnObliczSumeSzeregu.Name = "MYbtnObliczSumeSzeregu";
            this.MYbtnObliczSumeSzeregu.Size = new System.Drawing.Size(236, 34);
            this.MYbtnObliczSumeSzeregu.TabIndex = 48;
            this.MYbtnObliczSumeSzeregu.Text = "Oblicz sumę sheregu";
            this.MYbtnObliczSumeSzeregu.UseVisualStyleBackColor = true;
            this.MYbtnObliczSumeSzeregu.Click += new System.EventHandler(this.OBAbtnObliczSumeSzeregu_Click);
            // 
            // MYbtnExit
            // 
            this.MYbtnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MYbtnExit.Location = new System.Drawing.Point(1018, 637);
            this.MYbtnExit.Name = "MYbtnExit";
            this.MYbtnExit.Size = new System.Drawing.Size(115, 34);
            this.MYbtnExit.TabIndex = 47;
            this.MYbtnExit.Text = "Exit";
            this.MYbtnExit.UseVisualStyleBackColor = true;
            this.MYbtnExit.Click += new System.EventHandler(this.OBAbtnExit_Click);
            // 
            // OBAtxtLicznikWyrazuSzeregu
            // 
            this.OBAtxtLicznikWyrazuSzeregu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OBAtxtLicznikWyrazuSzeregu.Location = new System.Drawing.Point(899, 196);
            this.OBAtxtLicznikWyrazuSzeregu.Name = "OBAtxtLicznikWyrazuSzeregu";
            this.OBAtxtLicznikWyrazuSzeregu.ReadOnly = true;
            this.OBAtxtLicznikWyrazuSzeregu.Size = new System.Drawing.Size(236, 34);
            this.OBAtxtLicznikWyrazuSzeregu.TabIndex = 50;
            // 
            // MYbtnBack
            // 
            this.MYbtnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MYbtnBack.Location = new System.Drawing.Point(900, 637);
            this.MYbtnBack.Name = "MYbtnBack";
            this.MYbtnBack.Size = new System.Drawing.Size(115, 34);
            this.MYbtnBack.TabIndex = 46;
            this.MYbtnBack.Text = "Back";
            this.MYbtnBack.UseVisualStyleBackColor = true;
            this.MYbtnBack.Click += new System.EventHandler(this.OBAbtnBack_Click);
            // 
            // OBAchtWykresSzeregu
            // 
            chartArea1.Name = "ChartArea1";
            this.OBAchtWykresSzeregu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.OBAchtWykresSzeregu.Legends.Add(legend1);
            this.OBAchtWykresSzeregu.Location = new System.Drawing.Point(259, 21);
            this.OBAchtWykresSzeregu.Name = "OBAchtWykresSzeregu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.OBAchtWykresSzeregu.Series.Add(series1);
            this.OBAchtWykresSzeregu.Size = new System.Drawing.Size(622, 622);
            this.OBAchtWykresSzeregu.TabIndex = 68;
            this.OBAchtWykresSzeregu.Text = "chart1";
            // 
            // OBAerrorProvider1
            // 
            this.OBAerrorProvider1.ContainerControl = this;
            // 
            // OBAptrbRysownica
            // 
            this.OBAptrbRysownica.Location = new System.Drawing.Point(259, 21);
            this.OBAptrbRysownica.Name = "OBAptrbRysownica";
            this.OBAptrbRysownica.Size = new System.Drawing.Size(622, 622);
            this.OBAptrbRysownica.TabIndex = 69;
            this.OBAptrbRysownica.TabStop = false;
            this.OBAptrbRysownica.Click += new System.EventHandler(this.OBAptrbRysownica_Click);
            this.OBAptrbRysownica.Paint += new System.Windows.Forms.PaintEventHandler(this.OBAptrbRysownica_Paint);
            // 
            // btnAnimacja
            // 
            this.btnAnimacja.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnimacja.Location = new System.Drawing.Point(899, 470);
            this.btnAnimacja.Name = "btnAnimacja";
            this.btnAnimacja.Size = new System.Drawing.Size(236, 91);
            this.btnAnimacja.TabIndex = 70;
            this.btnAnimacja.Text = "Animacijna\r\nwizualizacja zmian\r\nwartości szeregu";
            this.btnAnimacja.UseVisualStyleBackColor = true;
            this.btnAnimacja.Click += new System.EventHandler(this.btnAnimacja_Click);
            // 
            // OBAtimer1
            // 
            this.OBAtimer1.Tick += new System.EventHandler(this.OBAtimer1_Tick);
            // 
            // ProjectInduwydualny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 683);
            this.Controls.Add(this.btnAnimacja);
            this.Controls.Add(this.OBAptrbRysownica);
            this.Controls.Add(this.OBAchtWykresSzeregu);
            this.Controls.Add(this.OBAdgvTWS);
            this.Controls.Add(this.MYbtnResetuj);
            this.Controls.Add(this.MYbtnWizualizacjaGraficzna);
            this.Controls.Add(this.MYbtnWizualizacjaTabelaryczna);
            this.Controls.Add(this.OBAtxtH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OBAtxtXg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OBAtxtXd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OBAtxtEps);
            this.Controls.Add(this.OBAtxtX);
            this.Controls.Add(this.OBAtxtSuma);
            this.Controls.Add(this.MYbtnObliczSumeSzeregu);
            this.Controls.Add(this.MYbtnExit);
            this.Controls.Add(this.OBAtxtLicznikWyrazuSzeregu);
            this.Controls.Add(this.MYbtnBack);
            this.MaximizeBox = false;
            this.Name = "ProjectInduwydualny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ates_64504";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Project_FormClosing);
            this.Load += new System.EventHandler(this.ProjectInduwydualny_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OBAdgvTWS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBAchtWykresSzeregu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBAerrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBAptrbRysownica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OBAdgvTWS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MYWartośćX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MYWartośćSzeregu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MYLicznikWyrazów;
        private System.Windows.Forms.Button MYbtnResetuj;
        private System.Windows.Forms.Button MYbtnWizualizacjaGraficzna;
        private System.Windows.Forms.Button MYbtnWizualizacjaTabelaryczna;
        private System.Windows.Forms.TextBox OBAtxtH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OBAtxtXg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OBAtxtXd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OBAtxtEps;
        private System.Windows.Forms.TextBox OBAtxtX;
        private System.Windows.Forms.TextBox OBAtxtSuma;
        private System.Windows.Forms.Button MYbtnObliczSumeSzeregu;
        private System.Windows.Forms.Button MYbtnExit;
        private System.Windows.Forms.TextBox OBAtxtLicznikWyrazuSzeregu;
        private System.Windows.Forms.Button MYbtnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart OBAchtWykresSzeregu;
        private System.Windows.Forms.ErrorProvider OBAerrorProvider1;
        private System.Windows.Forms.PictureBox OBAptrbRysownica;
        private System.Windows.Forms.Button btnAnimacja;
        private System.Windows.Forms.Timer OBAtimer1;
    }
}