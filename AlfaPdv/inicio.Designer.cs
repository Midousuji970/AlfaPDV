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
            btnProd = new Button();
            btnCli = new Button();
            btnFun = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlini = new Panel();
            SuspendLayout();
            // 
            // btnProd
            // 
            btnProd.Location = new Point(207, 236);
            btnProd.Name = "btnProd";
            btnProd.Size = new Size(117, 52);
            btnProd.TabIndex = 0;
            btnProd.Text = "Produto";
            btnProd.UseVisualStyleBackColor = true;
            btnProd.Click += btnProd_Click;
            // 
            // btnCli
            // 
            btnCli.Location = new Point(207, 308);
            btnCli.Name = "btnCli";
            btnCli.Size = new Size(117, 52);
            btnCli.TabIndex = 1;
            btnCli.Text = "Cliente";
            btnCli.UseVisualStyleBackColor = true;
            btnCli.Click += btnCli_Click;
            // 
            // btnFun
            // 
            btnFun.Location = new Point(207, 380);
            btnFun.Name = "btnFun";
            btnFun.Size = new Size(117, 52);
            btnFun.TabIndex = 2;
            btnFun.Text = "Funcionario";
            btnFun.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(577, 236);
            button4.Name = "button4";
            button4.Size = new Size(117, 52);
            button4.TabIndex = 3;
            button4.Text = "Iniciar Sessão";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(577, 308);
            button5.Name = "button5";
            button5.Size = new Size(117, 52);
            button5.TabIndex = 4;
            button5.Text = "Forma de Pagamento";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(577, 380);
            button6.Name = "button6";
            button6.Size = new Size(117, 52);
            button6.TabIndex = 5;
            button6.Text = "Historico de Vendas";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(934, 236);
            button7.Name = "button7";
            button7.Size = new Size(117, 52);
            button7.TabIndex = 6;
            button7.Text = "Configurações";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(934, 308);
            button8.Name = "button8";
            button8.Size = new Size(117, 52);
            button8.TabIndex = 7;
            button8.Text = "Empresa";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(934, 380);
            button9.Name = "button9";
            button9.Size = new Size(117, 52);
            button9.TabIndex = 8;
            button9.Text = "Sair";
            button9.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 36F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(176, 156);
            label1.Name = "label1";
            label1.Size = new Size(185, 57);
            label1.TabIndex = 9;
            label1.Text = "Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 36F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(568, 156);
            label2.Name = "label2";
            label2.Size = new Size(139, 57);
            label2.TabIndex = 10;
            label2.Text = "Venda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Narrow", 36F, FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(904, 156);
            label3.Name = "label3";
            label3.Size = new Size(188, 57);
            label3.TabIndex = 11;
            label3.Text = "Utilitarios";
            // 
            // pnlini
            // 
            pnlini.Dock = DockStyle.Fill;
            pnlini.Location = new Point(0, 0);
            pnlini.Name = "pnlini";
            pnlini.Size = new Size(1264, 681);
            pnlini.TabIndex = 12;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1264, 681);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnFun);
            Controls.Add(btnCli);
            Controls.Add(btnProd);
            Controls.Add(pnlini);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlfaPDV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProd;
        private Button btnCli;
        private Button btnFun;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel pnlini;
    }
}