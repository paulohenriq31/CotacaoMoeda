namespace CompraVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbMoedas = new System.Windows.Forms.ComboBox();
            this.btnCotacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbMoedas
            // 
            this.cmbMoedas.FormattingEnabled = true;
            this.cmbMoedas.Items.AddRange(new object[] {
            "Dólar (Compra)",
            "Dólar (Venda)",
            "Euro (Compra)",
            "Euro (Venda)",
            "Iene (Compra)",
            "Iene (Venda)",
            "Dólar Canadense (Compra)",
            "Dólar Canadense (Venda)"});
            this.cmbMoedas.Location = new System.Drawing.Point(62, 51);
            this.cmbMoedas.Name = "cmbMoedas";
            this.cmbMoedas.Size = new System.Drawing.Size(121, 21);
            this.cmbMoedas.TabIndex = 0;
            // 
            // btnCotacao
            // 
            this.btnCotacao.Location = new System.Drawing.Point(214, 34);
            this.btnCotacao.Name = "btnCotacao";
            this.btnCotacao.Size = new System.Drawing.Size(121, 52);
            this.btnCotacao.TabIndex = 1;
            this.btnCotacao.Text = "COTAÇÃO";
            this.btnCotacao.UseVisualStyleBackColor = true;
            this.btnCotacao.Click += new System.EventHandler(this.btnCotacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Moeda:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 129);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCotacao);
            this.Controls.Add(this.cmbMoedas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação Moedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMoedas;
        private System.Windows.Forms.Button btnCotacao;
        private System.Windows.Forms.Label label1;
    }
}

