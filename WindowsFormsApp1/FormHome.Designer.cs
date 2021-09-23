namespace WindowsFormsApp1
{
    partial class Form1
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
            this.title1 = new System.Windows.Forms.Label();
            this.buttonVente = new System.Windows.Forms.Button();
            this.buttonGds = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title1
            // 
            this.title1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.title1.Location = new System.Drawing.Point(315, 24);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(167, 49);
            this.title1.TabIndex = 0;
            this.title1.Text = "Opticien";
            // 
            // buttonVente
            // 
            this.buttonVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonVente.Location = new System.Drawing.Point(121, 171);
            this.buttonVente.Name = "buttonVente";
            this.buttonVente.Size = new System.Drawing.Size(253, 100);
            this.buttonVente.TabIndex = 1;
            this.buttonVente.Text = "Vente | Réservation";
            this.buttonVente.UseVisualStyleBackColor = true;
            this.buttonVente.Click += new System.EventHandler(this.buttonVente_Click);
            // 
            // buttonGds
            // 
            this.buttonGds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonGds.Location = new System.Drawing.Point(411, 171);
            this.buttonGds.Name = "buttonGds";
            this.buttonGds.Size = new System.Drawing.Size(253, 100);
            this.buttonGds.TabIndex = 2;
            this.buttonGds.Text = "Gestion des Stocks";
            this.buttonGds.UseVisualStyleBackColor = true;
            this.buttonGds.Click += new System.EventHandler(this.buttonGds_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonExit.Location = new System.Drawing.Point(304, 380);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(194, 58);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGds);
            this.Controls.Add(this.buttonVente);
            this.Controls.Add(this.title1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonExit;

        private System.Windows.Forms.Button buttonVente;
        private System.Windows.Forms.Button buttonGds;

        private System.Windows.Forms.Label title1;

        #endregion
    }
}