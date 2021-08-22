namespace GestorDePacientes
{
    partial class fomPruebasCreadas
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
            this.btnRealizar = new System.Windows.Forms.Button();
            this.DgvPruebasCreadas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPruebasCreadas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.DgvPruebasCreadas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRealizar, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 224);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRealizar
            // 
            this.btnRealizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRealizar.Location = new System.Drawing.Point(3, 189);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(333, 32);
            this.btnRealizar.TabIndex = 1;
            this.btnRealizar.Text = "Realizar Prueba";
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // DgvPruebasCreadas
            // 
            this.DgvPruebasCreadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPruebasCreadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPruebasCreadas.Location = new System.Drawing.Point(3, 3);
            this.DgvPruebasCreadas.Name = "DgvPruebasCreadas";
            this.DgvPruebasCreadas.Size = new System.Drawing.Size(333, 180);
            this.DgvPruebasCreadas.TabIndex = 2;
            this.DgvPruebasCreadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPruebasCreadas_CellClick);
            // 
            // fomPruebasCreadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 228);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fomPruebasCreadas";
            this.Text = "fomPruebasCreadas";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPruebasCreadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.DataGridView DgvPruebasCreadas;
    }
}