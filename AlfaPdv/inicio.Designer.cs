namespace AlfaPdv
{
    partial class Inicio
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
            btnSessao = new Button();
            btnForm = new Button();
            btnHist = new Button();
            btnConf = new Button();
            btnProprio = new Button();
            btnSair = new Button();
            lblVenda = new Label();
            lblUtil = new Label();
            pnlini = new Panel();
            tblPnlIni = new TableLayoutPanel();
            btnFun = new Button();
            btnCli = new Button();
            btnProd = new Button();
            lblCad = new Label();
            pnlEsq = new Panel();
            pnlini.SuspendLayout();
            tblPnlIni.SuspendLayout();
            SuspendLayout();
            // 
            // btnSessao
            // 
            btnSessao.Dock = DockStyle.Fill;
            btnSessao.Location = new Point(493, 229);
            btnSessao.Name = "btnSessao";
            btnSessao.Size = new Size(274, 107);
            btnSessao.TabIndex = 3;
            btnSessao.Text = "Iniciar Sessão";
            btnSessao.UseVisualStyleBackColor = true;
            btnSessao.Click += btnSessao_Click;
            // 
            // btnForm
            // 
            btnForm.Dock = DockStyle.Fill;
            btnForm.Location = new Point(493, 342);
            btnForm.Name = "btnForm";
            btnForm.Size = new Size(274, 107);
            btnForm.TabIndex = 4;
            btnForm.Text = "Forma de Pagamento";
            btnForm.UseVisualStyleBackColor = true;
            // 
            // btnHist
            // 
            btnHist.Dock = DockStyle.Fill;
            btnHist.Location = new Point(493, 455);
            btnHist.Name = "btnHist";
            btnHist.Size = new Size(274, 107);
            btnHist.TabIndex = 5;
            btnHist.Text = "Historico de Vendas";
            btnHist.UseVisualStyleBackColor = true;
            // 
            // btnConf
            // 
            btnConf.Dock = DockStyle.Fill;
            btnConf.Location = new Point(773, 229);
            btnConf.Name = "btnConf";
            btnConf.Size = new Size(274, 107);
            btnConf.TabIndex = 6;
            btnConf.Text = "Configurações";
            btnConf.UseVisualStyleBackColor = true;
            // 
            // btnProprio
            // 
            btnProprio.Dock = DockStyle.Fill;
            btnProprio.Location = new Point(773, 342);
            btnProprio.Name = "btnProprio";
            btnProprio.Size = new Size(274, 107);
            btnProprio.TabIndex = 7;
            btnProprio.Text = "Empresa";
            btnProprio.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Fill;
            btnSair.Location = new Point(773, 455);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(274, 107);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // lblVenda
            // 
            lblVenda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblVenda.AutoSize = true;
            lblVenda.BackColor = Color.Transparent;
            lblVenda.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Underline, GraphicsUnit.Point);
            lblVenda.ForeColor = SystemColors.ButtonHighlight;
            lblVenda.Location = new Point(548, 113);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(164, 113);
            lblVenda.TabIndex = 10;
            lblVenda.Text = "Venda";
            lblVenda.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblUtil
            // 
            lblUtil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblUtil.AutoSize = true;
            lblUtil.BackColor = Color.Transparent;
            lblUtil.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Underline, GraphicsUnit.Point);
            lblUtil.ForeColor = SystemColors.ButtonHighlight;
            lblUtil.Location = new Point(800, 113);
            lblUtil.Name = "lblUtil";
            lblUtil.Size = new Size(219, 113);
            lblUtil.TabIndex = 11;
            lblUtil.Text = "Utilitarios";
            lblUtil.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlini
            // 
            pnlini.Controls.Add(tblPnlIni);
            pnlini.Dock = DockStyle.Fill;
            pnlini.Location = new Point(0, 0);
            pnlini.Name = "pnlini";
            pnlini.Size = new Size(1264, 681);
            pnlini.TabIndex = 12;
            // 
            // tblPnlIni
            // 
            tblPnlIni.BackColor = Color.FromArgb(54, 73, 84);
            tblPnlIni.ColumnCount = 5;
            tblPnlIni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.664999F));
            tblPnlIni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.223341F));
            tblPnlIni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2233334F));
            tblPnlIni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2233334F));
            tblPnlIni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6649933F));
            tblPnlIni.Controls.Add(btnFun, 1, 4);
            tblPnlIni.Controls.Add(lblVenda, 2, 1);
            tblPnlIni.Controls.Add(btnCli, 1, 3);
            tblPnlIni.Controls.Add(btnSair, 3, 4);
            tblPnlIni.Controls.Add(btnProd, 1, 2);
            tblPnlIni.Controls.Add(btnProprio, 3, 3);
            tblPnlIni.Controls.Add(btnConf, 3, 2);
            tblPnlIni.Controls.Add(btnHist, 2, 4);
            tblPnlIni.Controls.Add(btnSessao, 2, 2);
            tblPnlIni.Controls.Add(btnForm, 2, 3);
            tblPnlIni.Controls.Add(lblCad, 1, 1);
            tblPnlIni.Controls.Add(lblUtil, 3, 1);
            tblPnlIni.Dock = DockStyle.Fill;
            tblPnlIni.Location = new Point(0, 0);
            tblPnlIni.Name = "tblPnlIni";
            tblPnlIni.RowCount = 6;
            tblPnlIni.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblPnlIni.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblPnlIni.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblPnlIni.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblPnlIni.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblPnlIni.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblPnlIni.Size = new Size(1264, 681);
            tblPnlIni.TabIndex = 0;
            // 
            // btnFun
            // 
            btnFun.Dock = DockStyle.Fill;
            btnFun.Location = new Point(213, 455);
            btnFun.Name = "btnFun";
            btnFun.Size = new Size(274, 107);
            btnFun.TabIndex = 2;
            btnFun.Text = "Funcionario";
            btnFun.UseVisualStyleBackColor = true;
            // 
            // btnCli
            // 
            btnCli.Dock = DockStyle.Fill;
            btnCli.Location = new Point(213, 342);
            btnCli.Name = "btnCli";
            btnCli.Size = new Size(274, 107);
            btnCli.TabIndex = 1;
            btnCli.Text = "Cliente";
            btnCli.UseVisualStyleBackColor = true;
            btnCli.Click += btnCli_Click;
            // 
            // btnProd
            // 
            btnProd.Dock = DockStyle.Fill;
            btnProd.Location = new Point(213, 229);
            btnProd.Name = "btnProd";
            btnProd.Size = new Size(274, 107);
            btnProd.TabIndex = 0;
            btnProd.Text = "Produto";
            btnProd.UseVisualStyleBackColor = true;
            btnProd.Click += btnProd_Click;
            // 
            // lblCad
            // 
            lblCad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblCad.AutoSize = true;
            lblCad.BackColor = Color.Transparent;
            lblCad.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Underline, GraphicsUnit.Point);
            lblCad.ForeColor = SystemColors.ButtonHighlight;
            lblCad.Location = new Point(240, 113);
            lblCad.Name = "lblCad";
            lblCad.Size = new Size(220, 113);
            lblCad.TabIndex = 9;
            lblCad.Text = "Cadastro";
            lblCad.TextAlign = ContentAlignment.BottomRight;
            // 
            // pnlEsq
            // 
            pnlEsq.Dock = DockStyle.Fill;
            pnlEsq.Location = new Point(3, 3);
            pnlEsq.Name = "pnlEsq";
            pnlEsq.Size = new Size(449, 675);
            pnlEsq.TabIndex = 0;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlini);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlfaPDV";
            pnlini.ResumeLayout(false);
            tblPnlIni.ResumeLayout(false);
            tblPnlIni.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSessao;
        private Button btnForm;
        private Button btnHist;
        private Button btnConf;
        private Button btnProprio;
        private Button btnSair;
        private Label lblVenda;
        private Label lblUtil;
        private Panel pnlini;
        private Panel pnlEsq;
        private Button btnProd;
        private TableLayoutPanel tblPnlIni;
        private Button btnFun;
        private Button btnCli;
        private Label lblCad;
    }
}