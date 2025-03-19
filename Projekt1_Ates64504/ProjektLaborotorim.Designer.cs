namespace Projekt1_Ates64504
{
    partial class ProjektLaborotorim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjektLaborotorim));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ptrbRysownica = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtXd = new System.Windows.Forms.TextBox();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnimacja = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.Location = new System.Drawing.Point(1022, 424);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 34);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(1022, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ptrbRysownica
            // 
            this.ptrbRysownica.Image = ((System.Drawing.Image)(resources.GetObject("ptrbRysownica.Image")));
            this.ptrbRysownica.InitialImage = null;
            this.ptrbRysownica.Location = new System.Drawing.Point(24, 98);
            this.ptrbRysownica.Name = "ptrbRysownica";
            this.ptrbRysownica.Size = new System.Drawing.Size(992, 559);
            this.ptrbRysownica.TabIndex = 2;
            this.ptrbRysownica.TabStop = false;
            this.ptrbRysownica.Click += new System.EventHandler(this.ptrbRysownica_Click);
            this.ptrbRysownica.Paint += new System.Windows.Forms.PaintEventHandler(this.ptrbRysownica_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtXd
            // 
            this.txtXd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtXd.Location = new System.Drawing.Point(127, 12);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(100, 34);
            this.txtXd.TabIndex = 3;
            // 
            // txtXg
            // 
            this.txtXg.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtXg.Location = new System.Drawing.Point(304, 12);
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(100, 34);
            this.txtXg.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Xd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(258, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Xg";
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtH.Location = new System.Drawing.Point(472, 12);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 34);
            this.txtH.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(442, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "h";
            // 
            // btnAnimacja
            // 
            this.btnAnimacja.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnimacja.Location = new System.Drawing.Point(1022, 384);
            this.btnAnimacja.Name = "btnAnimacja";
            this.btnAnimacja.Size = new System.Drawing.Size(141, 34);
            this.btnAnimacja.TabIndex = 9;
            this.btnAnimacja.Text = "Animacja";
            this.btnAnimacja.UseVisualStyleBackColor = true;
            this.btnAnimacja.Click += new System.EventHandler(this.btnAnimacja_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProjektLaborotorim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 711);
            this.Controls.Add(this.btnAnimacja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.ptrbRysownica);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.MaximizeBox = false;
            this.Name = "ProjektLaborotorim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OsmanAtes_54504";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Laboratory_FormClosing);
            this.Load += new System.EventHandler(this.ProjektLaborotorim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox ptrbRysownica;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnimacja;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}