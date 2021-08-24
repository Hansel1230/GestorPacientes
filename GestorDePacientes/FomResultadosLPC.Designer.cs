namespace GestorDePacientes
{
    partial class FomResultadosLPC
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
            this.DgvResultLPC = new System.Windows.Forms.DataGridView();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultLPC)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.08913F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.91087F));
            this.tableLayoutPanel1.Controls.Add(this.DgvResultLPC, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCompletar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCerrar, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DgvResultLPC
            // 
            this.DgvResultLPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DgvResultLPC, 2);
            this.DgvResultLPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvResultLPC.Location = new System.Drawing.Point(3, 3);
            this.DgvResultLPC.Name = "DgvResultLPC";
            this.DgvResultLPC.Size = new System.Drawing.Size(555, 260);
            this.DgvResultLPC.TabIndex = 0;
            // 
            // btnCompletar
            // 
            this.btnCompletar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompletar.Location = new System.Drawing.Point(3, 269);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(275, 83);
            this.btnCompletar.TabIndex = 1;
            this.btnCompletar.Text = "Completar cita";
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrar.Location = new System.Drawing.Point(284, 269);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(274, 83);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar resultados";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FomResultadosLPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FomResultadosLPC";
            this.Text = "FomResultadosLPC";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultLPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DgvResultLPC;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Button btnCerrar;
    }
}