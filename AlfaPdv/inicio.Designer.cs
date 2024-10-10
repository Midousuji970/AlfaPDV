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
            pnlini = new Panel();
            tblPnlIni = new TableLayoutPanel();
            btnFun = new Button();
            btnCli = new Button();
            btnProd = new Button();
            pnlEsq = new Panel();
            pnlini.SuspendLayout();
            tblPnlIni.SuspendLayout();
            SuspendLayout();
            // 
            // btnSessao
            // 
            btnSessao.Dock = DockStyle.Fill;
            btnSessao.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSessao.ForeColor = Color.White;
            btnSessao.Image = Properties.Resources.shopping_cart__1___1_;
            btnSessao.Location = new Point(501, 148);
            btnSessao.Name = "btnSessao";
            btnSessao.Size = new Size(279, 139);
            btnSessao.TabIndex = 3;
            btnSessao.Text = "Iniciar Sessão";
            btnSessao.TextAlign = ContentAlignment.BottomCenter;
            btnSessao.UseVisualStyleBackColor = false;
            btnSessao.Click += btnSessao_Click;
            // 
            // btnForm
            // 
            btnForm.Dock = DockStyle.Fill;
            btnForm.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnForm.ForeColor = Color.White;
            btnForm.Image = Properties.Resources.credit_card__1_;
            btnForm.Location = new Point(501, 293);
            btnForm.Name = "btnForm";
            btnForm.Size = new Size(279, 139);
            btnForm.TabIndex = 4;
            btnForm.Text = "Forma de Pagamento";
            btnForm.TextAlign = ContentAlignment.BottomCenter;
            btnForm.UseVisualStyleBackColor = false;
            // 
            // btnHist
            // 
            btnHist.Dock = DockStyle.Fill;
            btnHist.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHist.ForeColor = Color.White;
            btnHist.Image = Properties.Resources.clipboard__1_;
            btnHist.Location = new Point(501, 438);
            btnHist.Name = "btnHist";
            btnHist.Size = new Size(279, 139);
            btnHist.TabIndex = 5;
            btnHist.Text = "Historico de Vendas";
            btnHist.TextAlign = ContentAlignment.BottomCenter;
            btnHist.UseVisualStyleBackColor = false;
            // 
            // btnConf
            // 
            btnConf.Dock = DockStyle.Fill;
            btnConf.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConf.ForeColor = Color.White;
            btnConf.Image = Properties.Resources.settings__1_;
            btnConf.Location = new Point(786, 148);
            btnConf.Name = "btnConf";
            btnConf.Size = new Size(279, 139);
            btnConf.TabIndex = 6;
            btnConf.Text = "Configurações";
            btnConf.TextAlign = ContentAlignment.BottomCenter;
            btnConf.UseVisualStyleBackColor = false;
            // 
            // btnProprio
            // 
            btnProprio.Dock = DockStyle.Fill;
            btnProprio.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProprio.ForeColor = Color.White;
            btnProprio.Image = Properties.Resources.building__1_;
            btnProprio.Location = new Point(786, 293);
            btnProprio.Name = "btnProprio";
            btnProprio.Size = new Size(279, 139);
            btnProprio.TabIndex = 7;
            btnProprio.Text = "Empresa";
            btnProprio.TextAlign = ContentAlignment.BottomCenter;
            btnProprio.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Fill;
            btnSair.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.ForeColor = Color.White;
            btnSair.Image = Properties.Resources.power_off__1_;
            btnSair.Location = new Point(786, 438);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(279, 139);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            btnSair.UseVisualStyleBackColor = false;
            // 
            // pnlini
            // 
            pnlini.Controls.Add(tblPnlIni);
            pnlini.Dock = DockStyle.Fill;
            pnlini.Location = new Point(0, 0);
            pnlini.Name = "pnlini";
            pnlini.Size = new Size(1284, 729);
            pnlini.TabIndex = 12;
            // 
            // tblPnlIni
            // 
            tblPnlIni.BackColor = Color.FromArgb(54, 73, 84);
            tblPnlIni.ColumnCount = 5;
            tblPnlIni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.665F));
            tblPnlIni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.223341F));
            tblPnlIni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2233334F));
            tblPnlIni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2233334F));
            tblPnlIni.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66499F));
            tblPnlIni.Controls.Add(btnFun, 1, 3);
            tblPnlIni.Controls.Add(btnCli, 1, 2);
            tblPnlIni.Controls.Add(btnSair, 3, 3);
            tblPnlIni.Controls.Add(btnProd, 1, 1);
            tblPnlIni.Controls.Add(btnProprio, 3, 2);
            tblPnlIni.Controls.Add(btnConf, 3, 1);
            tblPnlIni.Controls.Add(btnHist, 2, 3);
            tblPnlIni.Controls.Add(btnSessao, 2, 1);
            tblPnlIni.Controls.Add(btnForm, 2, 2);
            tblPnlIni.Dock = DockStyle.Fill;
            tblPnlIni.Location = new Point(0, 0);
            tblPnlIni.Name = "tblPnlIni";
            tblPnlIni.RowCount = 5;
            tblPnlIni.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000038F));
            tblPnlIni.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tblPnlIni.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tblPnlIni.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tblPnlIni.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000038F));
            tblPnlIni.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPnlIni.Size = new Size(1284, 729);
            tblPnlIni.TabIndex = 0;
            // 
            // btnFun
            // 
            btnFun.Dock = DockStyle.Fill;
            btnFun.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFun.ForeColor = Color.White;
            btnFun.Image = Properties.Resources.user__1_;
            btnFun.Location = new Point(216, 438);
            btnFun.Name = "btnFun";
            btnFun.Size = new Size(279, 139);
            btnFun.TabIndex = 2;
            btnFun.Text = "Funcionario";
            btnFun.TextAlign = ContentAlignment.BottomCenter;
            btnFun.UseVisualStyleBackColor = false;
            // 
            // btnCli
            // 
            btnCli.BackColor = Color.FromArgb(54, 73, 84);
            btnCli.Dock = DockStyle.Fill;
            btnCli.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCli.ForeColor = Color.White;
            btnCli.Image = Properties.Resources.client__1_;
            btnCli.Location = new Point(216, 293);
            btnCli.Name = "btnCli";
            btnCli.Padding = new Padding(0, 0, 0, 5);
            btnCli.Size = new Size(279, 139);
            btnCli.TabIndex = 1;
            btnCli.Text = "Cliente";
            btnCli.TextAlign = ContentAlignment.BottomCenter;
            btnCli.UseVisualStyleBackColor = false;
            btnCli.Click += btnCli_Click;
            // 
            // btnProd
            // 
            btnProd.BackColor = Color.FromArgb(54, 73, 84);
            btnProd.Dock = DockStyle.Fill;
            btnProd.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProd.ForeColor = Color.White;
            btnProd.Image = Properties.Resources.product__1_;
            btnProd.Location = new Point(216, 148);
            btnProd.Name = "btnProd";
            btnProd.Padding = new Padding(0, 0, 0, 5);
            btnProd.RightToLeft = RightToLeft.No;
            btnProd.Size = new Size(279, 139);
            btnProd.TabIndex = 0;
            btnProd.Text = "Produto";
            btnProd.TextAlign = ContentAlignment.BottomCenter;
            btnProd.UseVisualStyleBackColor = false;
            btnProd.Click += btnProd_Click;
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
            ClientSize = new Size(1284, 729);
            Controls.Add(pnlini);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlfaPDV";
            TopMost = true;
            pnlini.ResumeLayout(false);
            tblPnlIni.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnSessao;
        private Button btnForm;
        private Button btnHist;
        private Button btnConf;
        private Button btnProprio;
        private Button btnSair;
        private Panel pnlini;
        private Panel pnlEsq;
        private Button btnProd;
        private TableLayoutPanel tblPnlIni;
        private Button btnFun;
        private Button btnCli;
    }
}