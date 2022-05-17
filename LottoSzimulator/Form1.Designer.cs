
namespace LottoSzimulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tarolo = new System.Windows.Forms.Panel();
            this.btnSorsol = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tarolo
            // 
            this.tarolo.BackColor = System.Drawing.SystemColors.Info;
            this.tarolo.Location = new System.Drawing.Point(42, 49);
            this.tarolo.Name = "tarolo";
            this.tarolo.Size = new System.Drawing.Size(580, 500);
            this.tarolo.TabIndex = 0;
            // 
            // btnSorsol
            // 
            this.btnSorsol.Location = new System.Drawing.Point(646, 49);
            this.btnSorsol.Name = "btnSorsol";
            this.btnSorsol.Size = new System.Drawing.Size(75, 23);
            this.btnSorsol.TabIndex = 2;
            this.btnSorsol.Text = "Sorsolás";
            this.btnSorsol.UseVisualStyleBackColor = true;
            this.btnSorsol.Click += new System.EventHandler(this.btnSorsol_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(646, 87);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 3;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 582);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnSorsol);
            this.Controls.Add(this.tarolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tarolo;
        private System.Windows.Forms.Button btnSorsol;
        private System.Windows.Forms.Button btnBezar;
    }
}

