namespace Compras_X_Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBoxCompras = new TextBox();
            textBoxVendas = new TextBox();
            label3 = new Label();
            tbPorcentagem = new NumericUpDown();
            slidePorcentagem = new TrackBar();
            btCalcular = new Button();
            label4 = new Label();
            label5 = new Label();
            textBoxDiferenca = new TextBox();
            textBoxMeta = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            janelaToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbPorcentagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slidePorcentagem).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Compras:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(182, 30);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Vendas:";
            // 
            // textBoxCompras
            // 
            textBoxCompras.Location = new Point(76, 27);
            textBoxCompras.Name = "textBoxCompras";
            textBoxCompras.Size = new Size(100, 23);
            textBoxCompras.TabIndex = 1;
            textBoxCompras.KeyPress += ProximoIndice;
            // 
            // textBoxVendas
            // 
            textBoxVendas.Location = new Point(237, 27);
            textBoxVendas.Name = "textBoxVendas";
            textBoxVendas.Size = new Size(100, 23);
            textBoxVendas.TabIndex = 2;
            textBoxVendas.KeyPress += ProximoIndice;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 4;
            label3.Text = "Porcentagem de lucro bruto:";
            // 
            // tbPorcentagem
            // 
            tbPorcentagem.Location = new Point(177, 56);
            tbPorcentagem.Name = "tbPorcentagem";
            tbPorcentagem.Size = new Size(50, 23);
            tbPorcentagem.TabIndex = 3;
            tbPorcentagem.Value = new decimal(new int[] { 25, 0, 0, 0 });
            tbPorcentagem.KeyPress += ProximoIndice;
            tbPorcentagem.Leave += AlteraSlidePorcentagem;
            // 
            // slidePorcentagem
            // 
            slidePorcentagem.Location = new Point(12, 85);
            slidePorcentagem.Maximum = 100;
            slidePorcentagem.Name = "slidePorcentagem";
            slidePorcentagem.Size = new Size(325, 45);
            slidePorcentagem.TabIndex = 5;
            slidePorcentagem.TickFrequency = 10;
            slidePorcentagem.Value = 25;
            slidePorcentagem.Scroll += AlteraTbPorcentagem;
            // 
            // btCalcular
            // 
            btCalcular.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btCalcular.Location = new Point(12, 136);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(325, 32);
            btCalcular.TabIndex = 4;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += BtCalcularClick;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 8;
            label4.Text = "Meta venda:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(22, 52);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 9;
            label5.Text = "Diferença:";
            // 
            // textBoxDiferenca
            // 
            textBoxDiferenca.Anchor = AnchorStyles.None;
            textBoxDiferenca.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            textBoxDiferenca.Location = new Point(130, 49);
            textBoxDiferenca.Name = "textBoxDiferenca";
            textBoxDiferenca.ReadOnly = true;
            textBoxDiferenca.Size = new Size(192, 32);
            textBoxDiferenca.TabIndex = 10;
            // 
            // textBoxMeta
            // 
            textBoxMeta.Anchor = AnchorStyles.None;
            textBoxMeta.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            textBoxMeta.Location = new Point(130, 5);
            textBoxMeta.Name = "textBoxMeta";
            textBoxMeta.ReadOnly = true;
            textBoxMeta.Size = new Size(192, 32);
            textBoxMeta.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.0769234F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.9230766F));
            tableLayoutPanel1.Controls.Add(textBoxMeta, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxDiferenca, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 174);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(325, 87);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // janelaToolStripMenuItem
            // 
            janelaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { printToolStripMenuItem, calculadoraToolStripMenuItem, toolStripSeparator1, fecharToolStripMenuItem });
            janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            janelaToolStripMenuItem.Size = new Size(51, 20);
            janelaToolStripMenuItem.Text = "Janela";
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(180, 22);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += PrintMenuClick;
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Image = (Image)resources.GetObject("calculadoraToolStripMenuItem.Image");
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(180, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += CalcMenuClick;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(180, 22);
            fecharToolStripMenuItem.Text = "Sair";
            fecharToolStripMenuItem.Click += Fechar;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem1 });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(50, 20);
            sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem1
            // 
            sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            sobreToolStripMenuItem1.Size = new Size(104, 22);
            sobreToolStripMenuItem1.Text = "Sobre";
            sobreToolStripMenuItem1.Click += MenuSobre;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { janelaToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(348, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(233, 58);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 14;
            label6.Text = "%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 273);
            Controls.Add(label6);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(textBoxCompras);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(slidePorcentagem);
            Controls.Add(label2);
            Controls.Add(tbPorcentagem);
            Controls.Add(btCalcular);
            Controls.Add(textBoxVendas);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras X Vendas";
            ((System.ComponentModel.ISupportInitialize)tbPorcentagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)slidePorcentagem).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxCompras;
        private TextBox textBoxVendas;
        private Label label3;
        private NumericUpDown tbPorcentagem;
        private TrackBar slidePorcentagem;
        private Button btCalcular;
        private Label label4;
        private Label label5;
        private TextBox textBoxDiferenca;
        private TextBox textBoxMeta;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripMenuItem janelaToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private Label label6;
    }
}