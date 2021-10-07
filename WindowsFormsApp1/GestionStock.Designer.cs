using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class GestionStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gestion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFormations = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBMA = new System.Windows.Forms.ComboBox();
            this.cbCompetences = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.Gestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvFormations)).BeginInit();
            this.SuspendLayout();
            // 
            // Gestion
            // 
            this.Gestion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Gestion.Controls.Add(this.label3);
            this.Gestion.Controls.Add(this.dgvFormations);
            this.Gestion.Controls.Add(this.label2);
            this.Gestion.Controls.Add(this.label1);
            this.Gestion.Controls.Add(this.CBMA);
            this.Gestion.Controls.Add(this.cbCompetences);
            this.Gestion.Controls.Add(this.linkLabel1);
            this.Gestion.Location = new System.Drawing.Point(12, 12);
            this.Gestion.Name = "Gestion";
            this.Gestion.Size = new System.Drawing.Size(649, 377);
            this.Gestion.TabIndex = 0;
            this.Gestion.TabStop = false;
            this.Gestion.Text = "Gestion des stocks";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(280, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "STOCKS";
            // 
            // dgvFormations
            // 
            this.dgvFormations.AllowUserToAddRows = false;
            this.dgvFormations.AllowUserToDeleteRows = false;
            this.dgvFormations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFormations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFormations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormations.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFormations.Location = new System.Drawing.Point(48, 206);
            this.dgvFormations.MultiSelect = false;
            this.dgvFormations.Name = "dgvFormations";
            this.dgvFormations.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dgvFormations.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFormations.Size = new System.Drawing.Size(555, 150);
            this.dgvFormations.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(166, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modèle";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(166, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marque";
            // 
            // CBMA
            // 
            this.CBMA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMA.FormattingEnabled = true;
            this.CBMA.Location = new System.Drawing.Point(247, 64);
            this.CBMA.Name = "CBMA";
            this.CBMA.Size = new System.Drawing.Size(188, 21);
            this.CBMA.TabIndex = 2;
            this.CBMA.SelectedIndexChanged += new System.EventHandler(this.CBMA_SelectedIndexChanged);
            // 
            // cbCompetences
            // 
            this.cbCompetences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompetences.FormattingEnabled = true;
            this.cbCompetences.Location = new System.Drawing.Point(247, 107);
            this.cbCompetences.Name = "cbCompetences";
            this.cbCompetences.Size = new System.Drawing.Size(188, 21);
            this.cbCompetences.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(166, 258);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(8, 8);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(667, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonExit.Location = new System.Drawing.Point(668, 336);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 53);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // GestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gestion);
            this.Name = "GestionStock";
            this.Text = "GestionStock";
            this.Load += new System.EventHandler(this.GestionStock_Load);
            this.Gestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvFormations)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox CBMA;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.DataGridView dgvFormations;

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cbCompetences;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button buttonExit;

        private System.Windows.Forms.GroupBox Gestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        #endregion
    }
}