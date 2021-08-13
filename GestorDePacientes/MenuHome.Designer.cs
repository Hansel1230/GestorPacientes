namespace GestorDePacientes
{
    partial class MenuHome
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblMantenimientos = new System.Windows.Forms.Label();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.BtnMedico = new System.Windows.Forms.Button();
            this.BtnPrLabo = new System.Windows.Forms.Button();
            this.BtnPaciente = new System.Windows.Forms.Button();
            this.BtnCita = new System.Windows.Forms.Button();
            this.BtnResulPrLabo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblMantenimientos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnUsuario, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnMedico, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnPrLabo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnPaciente, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnCita, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.BtnResulPrLabo, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.977622F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.424084F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.13613F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.87435F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.39791F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.87435F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.61257F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(409, 382);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 3);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 22);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 18);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atrasToolStripMenuItem.Text = "Login";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // LblMantenimientos
            // 
            this.LblMantenimientos.AutoSize = true;
            this.LblMantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblMantenimientos.Location = new System.Drawing.Point(139, 22);
            this.LblMantenimientos.Name = "LblMantenimientos";
            this.LblMantenimientos.Size = new System.Drawing.Size(130, 13);
            this.LblMantenimientos.TabIndex = 1;
            this.LblMantenimientos.Text = "Mantenimientos";
            this.LblMantenimientos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUsuario.Location = new System.Drawing.Point(139, 61);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(130, 48);
            this.BtnUsuario.TabIndex = 2;
            this.BtnUsuario.Text = "Usuario";
            this.BtnUsuario.UseVisualStyleBackColor = true;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // BtnMedico
            // 
            this.BtnMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMedico.Location = new System.Drawing.Point(139, 115);
            this.BtnMedico.Name = "BtnMedico";
            this.BtnMedico.Size = new System.Drawing.Size(130, 47);
            this.BtnMedico.TabIndex = 3;
            this.BtnMedico.Text = "Medico";
            this.BtnMedico.UseVisualStyleBackColor = true;
            this.BtnMedico.Click += new System.EventHandler(this.BtnMedico_Click);
            // 
            // BtnPrLabo
            // 
            this.BtnPrLabo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPrLabo.Location = new System.Drawing.Point(139, 168);
            this.BtnPrLabo.Name = "BtnPrLabo";
            this.BtnPrLabo.Size = new System.Drawing.Size(130, 48);
            this.BtnPrLabo.TabIndex = 4;
            this.BtnPrLabo.Text = "Prueba de laboratorio";
            this.BtnPrLabo.UseVisualStyleBackColor = true;
            this.BtnPrLabo.Click += new System.EventHandler(this.BtnPrLabo_Click);
            // 
            // BtnPaciente
            // 
            this.BtnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPaciente.Location = new System.Drawing.Point(139, 222);
            this.BtnPaciente.Name = "BtnPaciente";
            this.BtnPaciente.Size = new System.Drawing.Size(130, 49);
            this.BtnPaciente.TabIndex = 5;
            this.BtnPaciente.Text = "Paciente";
            this.BtnPaciente.UseVisualStyleBackColor = true;
            this.BtnPaciente.Click += new System.EventHandler(this.BtnPaciente_Click);
            // 
            // BtnCita
            // 
            this.BtnCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCita.Location = new System.Drawing.Point(139, 277);
            this.BtnCita.Name = "BtnCita";
            this.BtnCita.Size = new System.Drawing.Size(130, 47);
            this.BtnCita.TabIndex = 6;
            this.BtnCita.Text = "Cita";
            this.BtnCita.UseVisualStyleBackColor = true;
            this.BtnCita.Click += new System.EventHandler(this.BtnCita_Click);
            // 
            // BtnResulPrLabo
            // 
            this.BtnResulPrLabo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnResulPrLabo.Location = new System.Drawing.Point(139, 330);
            this.BtnResulPrLabo.Name = "BtnResulPrLabo";
            this.BtnResulPrLabo.Size = new System.Drawing.Size(130, 48);
            this.BtnResulPrLabo.TabIndex = 7;
            this.BtnResulPrLabo.Text = "Resultado Prueba Laboratorio";
            this.BtnResulPrLabo.UseVisualStyleBackColor = true;
            this.BtnResulPrLabo.Click += new System.EventHandler(this.BtnResulPrLabo_Click);
            // 
            // MenuHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 382);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuHome";
            this.Text = "MenuHome";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.Label LblMantenimientos;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Button BtnMedico;
        private System.Windows.Forms.Button BtnPrLabo;
        private System.Windows.Forms.Button BtnPaciente;
        private System.Windows.Forms.Button BtnCita;
        private System.Windows.Forms.Button BtnResulPrLabo;
    }
}