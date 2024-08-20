namespace EstadosXRegioes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGeral = new System.Windows.Forms.ComboBox();
            this.RemoverGeral = new System.Windows.Forms.Button();
            this.TotalGeral = new System.Windows.Forms.Label();
            this.TotalNorte = new System.Windows.Forms.Label();
            this.RemoverNorte = new System.Windows.Forms.Button();
            this.cbxNorte = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalNordeste = new System.Windows.Forms.Label();
            this.RemoverNordeste = new System.Windows.Forms.Button();
            this.cbxNordeste = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalCentroOeste = new System.Windows.Forms.Label();
            this.RemoverCentroOeste = new System.Windows.Forms.Button();
            this.cbxCentroOeste = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalSudeste = new System.Windows.Forms.Label();
            this.RemoverSudeste = new System.Windows.Forms.Button();
            this.cbxSudeste = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalSul = new System.Windows.Forms.Label();
            this.RemoverSul = new System.Windows.Forms.Button();
            this.cbxSul = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos os Estados:";
            // 
            // cbxGeral
            // 
            this.cbxGeral.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGeral.FormattingEnabled = true;
            this.cbxGeral.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espirito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbxGeral.Location = new System.Drawing.Point(294, 55);
            this.cbxGeral.Name = "cbxGeral";
            this.cbxGeral.Size = new System.Drawing.Size(207, 37);
            this.cbxGeral.Sorted = true;
            this.cbxGeral.TabIndex = 1;
            // 
            // RemoverGeral
            // 
            this.RemoverGeral.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverGeral.Location = new System.Drawing.Point(551, 53);
            this.RemoverGeral.Name = "RemoverGeral";
            this.RemoverGeral.Size = new System.Drawing.Size(40, 40);
            this.RemoverGeral.TabIndex = 2;
            this.RemoverGeral.Text = "-";
            this.RemoverGeral.UseVisualStyleBackColor = true;
            this.RemoverGeral.Click += new System.EventHandler(this.RemoverGeral_Click);
            // 
            // TotalGeral
            // 
            this.TotalGeral.AutoSize = true;
            this.TotalGeral.Font = new System.Drawing.Font("Roboto Bk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalGeral.Location = new System.Drawing.Point(662, 57);
            this.TotalGeral.Name = "TotalGeral";
            this.TotalGeral.Size = new System.Drawing.Size(31, 33);
            this.TotalGeral.TabIndex = 3;
            this.TotalGeral.Text = "0";
            // 
            // TotalNorte
            // 
            this.TotalNorte.AutoSize = true;
            this.TotalNorte.Font = new System.Drawing.Font("Roboto Bk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNorte.Location = new System.Drawing.Point(662, 136);
            this.TotalNorte.Name = "TotalNorte";
            this.TotalNorte.Size = new System.Drawing.Size(31, 33);
            this.TotalNorte.TabIndex = 7;
            this.TotalNorte.Text = "0";
            // 
            // RemoverNorte
            // 
            this.RemoverNorte.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverNorte.Location = new System.Drawing.Point(551, 132);
            this.RemoverNorte.Name = "RemoverNorte";
            this.RemoverNorte.Size = new System.Drawing.Size(40, 40);
            this.RemoverNorte.TabIndex = 6;
            this.RemoverNorte.Text = "-";
            this.RemoverNorte.UseVisualStyleBackColor = true;
            this.RemoverNorte.Click += new System.EventHandler(this.RemoverNorte_Click);
            // 
            // cbxNorte
            // 
            this.cbxNorte.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNorte.FormattingEnabled = true;
            this.cbxNorte.Location = new System.Drawing.Point(294, 134);
            this.cbxNorte.Name = "cbxNorte";
            this.cbxNorte.Size = new System.Drawing.Size(207, 37);
            this.cbxNorte.Sorted = true;
            this.cbxNorte.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Região Norte:";
            // 
            // TotalNordeste
            // 
            this.TotalNordeste.AutoSize = true;
            this.TotalNordeste.Font = new System.Drawing.Font("Roboto Bk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNordeste.Location = new System.Drawing.Point(662, 215);
            this.TotalNordeste.Name = "TotalNordeste";
            this.TotalNordeste.Size = new System.Drawing.Size(31, 33);
            this.TotalNordeste.TabIndex = 11;
            this.TotalNordeste.Text = "0";
            // 
            // RemoverNordeste
            // 
            this.RemoverNordeste.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverNordeste.Location = new System.Drawing.Point(551, 211);
            this.RemoverNordeste.Name = "RemoverNordeste";
            this.RemoverNordeste.Size = new System.Drawing.Size(40, 40);
            this.RemoverNordeste.TabIndex = 10;
            this.RemoverNordeste.Text = "-";
            this.RemoverNordeste.UseVisualStyleBackColor = true;
            this.RemoverNordeste.Click += new System.EventHandler(this.RemoverNordeste_Click);
            // 
            // cbxNordeste
            // 
            this.cbxNordeste.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNordeste.FormattingEnabled = true;
            this.cbxNordeste.Location = new System.Drawing.Point(294, 213);
            this.cbxNordeste.Name = "cbxNordeste";
            this.cbxNordeste.Size = new System.Drawing.Size(207, 37);
            this.cbxNordeste.Sorted = true;
            this.cbxNordeste.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Região Nordeste:";
            // 
            // TotalCentroOeste
            // 
            this.TotalCentroOeste.AutoSize = true;
            this.TotalCentroOeste.Font = new System.Drawing.Font("Roboto Bk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCentroOeste.Location = new System.Drawing.Point(662, 294);
            this.TotalCentroOeste.Name = "TotalCentroOeste";
            this.TotalCentroOeste.Size = new System.Drawing.Size(31, 33);
            this.TotalCentroOeste.TabIndex = 15;
            this.TotalCentroOeste.Text = "0";
            // 
            // RemoverCentroOeste
            // 
            this.RemoverCentroOeste.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverCentroOeste.Location = new System.Drawing.Point(551, 290);
            this.RemoverCentroOeste.Name = "RemoverCentroOeste";
            this.RemoverCentroOeste.Size = new System.Drawing.Size(40, 40);
            this.RemoverCentroOeste.TabIndex = 14;
            this.RemoverCentroOeste.Text = "-";
            this.RemoverCentroOeste.UseVisualStyleBackColor = true;
            this.RemoverCentroOeste.Click += new System.EventHandler(this.RemoverCentroOeste_Click);
            // 
            // cbxCentroOeste
            // 
            this.cbxCentroOeste.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCentroOeste.FormattingEnabled = true;
            this.cbxCentroOeste.Location = new System.Drawing.Point(294, 292);
            this.cbxCentroOeste.Name = "cbxCentroOeste";
            this.cbxCentroOeste.Size = new System.Drawing.Size(207, 37);
            this.cbxCentroOeste.Sorted = true;
            this.cbxCentroOeste.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Região Centro-Oeste:";
            // 
            // TotalSudeste
            // 
            this.TotalSudeste.AutoSize = true;
            this.TotalSudeste.Font = new System.Drawing.Font("Roboto Bk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSudeste.Location = new System.Drawing.Point(662, 373);
            this.TotalSudeste.Name = "TotalSudeste";
            this.TotalSudeste.Size = new System.Drawing.Size(31, 33);
            this.TotalSudeste.TabIndex = 19;
            this.TotalSudeste.Text = "0";
            // 
            // RemoverSudeste
            // 
            this.RemoverSudeste.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverSudeste.Location = new System.Drawing.Point(551, 369);
            this.RemoverSudeste.Name = "RemoverSudeste";
            this.RemoverSudeste.Size = new System.Drawing.Size(40, 40);
            this.RemoverSudeste.TabIndex = 18;
            this.RemoverSudeste.Text = "-";
            this.RemoverSudeste.UseVisualStyleBackColor = true;
            this.RemoverSudeste.Click += new System.EventHandler(this.RemoverSudeste_Click);
            // 
            // cbxSudeste
            // 
            this.cbxSudeste.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSudeste.FormattingEnabled = true;
            this.cbxSudeste.Location = new System.Drawing.Point(294, 371);
            this.cbxSudeste.Name = "cbxSudeste";
            this.cbxSudeste.Size = new System.Drawing.Size(207, 37);
            this.cbxSudeste.Sorted = true;
            this.cbxSudeste.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(90, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "Região Sudeste:";
            // 
            // TotalSul
            // 
            this.TotalSul.AutoSize = true;
            this.TotalSul.Font = new System.Drawing.Font("Roboto Bk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSul.Location = new System.Drawing.Point(662, 452);
            this.TotalSul.Name = "TotalSul";
            this.TotalSul.Size = new System.Drawing.Size(31, 33);
            this.TotalSul.TabIndex = 23;
            this.TotalSul.Text = "0";
            // 
            // RemoverSul
            // 
            this.RemoverSul.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverSul.Location = new System.Drawing.Point(551, 448);
            this.RemoverSul.Name = "RemoverSul";
            this.RemoverSul.Size = new System.Drawing.Size(40, 40);
            this.RemoverSul.TabIndex = 22;
            this.RemoverSul.Text = "-";
            this.RemoverSul.UseVisualStyleBackColor = true;
            this.RemoverSul.Click += new System.EventHandler(this.RemoverSul_Click);
            // 
            // cbxSul
            // 
            this.cbxSul.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSul.FormattingEnabled = true;
            this.cbxSul.Location = new System.Drawing.Point(294, 450);
            this.cbxSul.Name = "cbxSul";
            this.cbxSul.Size = new System.Drawing.Size(207, 37);
            this.cbxSul.Sorted = true;
            this.cbxSul.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(145, 454);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "Região Sul:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 544);
            this.Controls.Add(this.TotalSul);
            this.Controls.Add(this.RemoverSul);
            this.Controls.Add(this.cbxSul);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TotalSudeste);
            this.Controls.Add(this.RemoverSudeste);
            this.Controls.Add(this.cbxSudeste);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TotalCentroOeste);
            this.Controls.Add(this.RemoverCentroOeste);
            this.Controls.Add(this.cbxCentroOeste);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TotalNordeste);
            this.Controls.Add(this.RemoverNordeste);
            this.Controls.Add(this.cbxNordeste);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalNorte);
            this.Controls.Add(this.RemoverNorte);
            this.Controls.Add(this.cbxNorte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalGeral);
            this.Controls.Add(this.RemoverGeral);
            this.Controls.Add(this.cbxGeral);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGeral;
        private System.Windows.Forms.Button RemoverGeral;
        private System.Windows.Forms.Label TotalGeral;
        private System.Windows.Forms.Label TotalNorte;
        private System.Windows.Forms.Button RemoverNorte;
        private System.Windows.Forms.ComboBox cbxNorte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalNordeste;
        private System.Windows.Forms.Button RemoverNordeste;
        private System.Windows.Forms.ComboBox cbxNordeste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalCentroOeste;
        private System.Windows.Forms.Button RemoverCentroOeste;
        private System.Windows.Forms.ComboBox cbxCentroOeste;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TotalSudeste;
        private System.Windows.Forms.Button RemoverSudeste;
        private System.Windows.Forms.ComboBox cbxSudeste;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TotalSul;
        private System.Windows.Forms.Button RemoverSul;
        private System.Windows.Forms.ComboBox cbxSul;
        private System.Windows.Forms.Label label12;
    }
}

