namespace Projekt1_Ates64504
{
    partial class Kokpit_Ates64504
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.btnLaboratory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(12, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(1123, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProject
            // 
            this.btnProject.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProject.Location = new System.Drawing.Point(577, 276);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(558, 90);
            this.btnProject.TabIndex = 2;
            this.btnProject.Text = "Projekt Nr 3\r\n(analizator indywidualnego szeregu potęgowego)";
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnLaboratory
            // 
            this.btnLaboratory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLaboratory.Location = new System.Drawing.Point(12, 276);
            this.btnLaboratory.Name = "btnLaboratory";
            this.btnLaboratory.Size = new System.Drawing.Size(557, 90);
            this.btnLaboratory.TabIndex = 3;
            this.btnLaboratory.Text = "Laboratorium Nr 3\r\n(analizator laboratoryjnego szeregu potęgowego)";
            this.btnLaboratory.UseVisualStyleBackColor = true;
            this.btnLaboratory.Click += new System.EventHandler(this.btnLaboratory_Click);
            // 
            // Kokpit_Ates64504
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 683);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProject);
            this.Controls.Add(this.btnLaboratory);
            this.MaximizeBox = false;
            this.Name = "Kokpit_Ates64504";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ates_64504";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartWindow_FormClosing);
            this.Load += new System.EventHandler(this.Kokpit_Ates64504_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnLaboratory;
    }
}

