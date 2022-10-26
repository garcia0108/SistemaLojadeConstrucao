namespace SistemaLojadeConstrucao
{
    partial class frmPrincipal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.btnProdutos = new System.Windows.Forms.ToolStripButton();
            this.btnFuncionarios = new System.Windows.Forms.ToolStripButton();
            this.btnOrcamentos = new System.Windows.Forms.ToolStripButton();
            this.btnVendas = new System.Windows.Forms.ToolStripButton();
            this.btnRelatorios = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientes,
            this.toolStripSeparator5,
            this.btnProdutos,
            this.toolStripSeparator6,
            this.btnFuncionarios,
            this.toolStripSeparator4,
            this.btnOrcamentos,
            this.toolStripSeparator2,
            this.btnVendas,
            this.toolStripSeparator3,
            this.btnRelatorios,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 70);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 70);
            this.toolStripSeparator5.Click += new System.EventHandler(this.toolStripSeparator4_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 70);
            this.toolStripSeparator6.Click += new System.EventHandler(this.toolStripSeparator4_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 70);
            this.toolStripSeparator4.Click += new System.EventHandler(this.toolStripSeparator4_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSize = false;
            this.btnClientes.Image = global::SistemaLojadeConstrucao.Properties.Resources.clientes;
            this.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(79, 67);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.AutoSize = false;
            this.btnProdutos.Image = global::SistemaLojadeConstrucao.Properties.Resources.produtos;
            this.btnProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(79, 67);
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.AutoSize = false;
            this.btnFuncionarios.Image = global::SistemaLojadeConstrucao.Properties.Resources.funcionários;
            this.btnFuncionarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFuncionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(79, 67);
            this.btnFuncionarios.Text = "Funcionário";
            this.btnFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnOrcamentos
            // 
            this.btnOrcamentos.AutoSize = false;
            this.btnOrcamentos.Image = global::SistemaLojadeConstrucao.Properties.Resources.orçamentos;
            this.btnOrcamentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOrcamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrcamentos.Name = "btnOrcamentos";
            this.btnOrcamentos.Size = new System.Drawing.Size(79, 67);
            this.btnOrcamentos.Text = "Orçamentos";
            this.btnOrcamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnVendas
            // 
            this.btnVendas.AutoSize = false;
            this.btnVendas.Image = global::SistemaLojadeConstrucao.Properties.Resources.vendas;
            this.btnVendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(79, 67);
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.AutoSize = false;
            this.btnRelatorios.Image = global::SistemaLojadeConstrucao.Properties.Resources.Relatorio_Produtos;
            this.btnRelatorios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(79, 67);
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 690);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema para Lojas de Materiais para Construção";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripButton btnProdutos;
        private System.Windows.Forms.ToolStripButton btnFuncionarios;
        private System.Windows.Forms.ToolStripButton btnOrcamentos;
        private System.Windows.Forms.ToolStripButton btnVendas;
        private System.Windows.Forms.ToolStripButton btnRelatorios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

