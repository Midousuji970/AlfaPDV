namespace AlfaPdv.PDV
{
    partial class Subtotal
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
            panel7 = new Panel();
            label1 = new Label();
            dgvPes = new DataGridView();
            btnCanItem = new Button();
            button2 = new Button();
            btnFimVenda = new Button();
            button5 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbTotal = new Label();
            label6 = new Label();
            btnFimSessao = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            pnlSub = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            panel8 = new Panel();
            mtxtPes = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPes).BeginInit();
            pnlSub.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(54, 63, 84);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(1253, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(11, 681);
            panel7.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(200, 212, 225);
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(46, 51, 73);
            label1.Location = new Point(681, 14);
            label1.Name = "label1";
            label1.Size = new Size(209, 29);
            label1.TabIndex = 7;
            label1.Text = "Digite o Produto:";
            // 
            // dgvPes
            // 
            dgvPes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPes.BackgroundColor = SystemColors.Control;
            dgvPes.BorderStyle = BorderStyle.None;
            dgvPes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPes.Location = new Point(336, 122);
            dgvPes.Name = "dgvPes";
            dgvPes.ReadOnly = true;
            dgvPes.RowTemplate.Height = 25;
            dgvPes.Size = new Size(906, 483);
            dgvPes.TabIndex = 9;
            // 
            // btnCanItem
            // 
            btnCanItem.BackColor = Color.FromArgb(54, 63, 84);
            btnCanItem.Dock = DockStyle.Fill;
            btnCanItem.FlatStyle = FlatStyle.Flat;
            btnCanItem.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCanItem.ForeColor = Color.White;
            btnCanItem.Location = new Point(3, 481);
            btnCanItem.Name = "btnCanItem";
            btnCanItem.Size = new Size(73, 81);
            btnCanItem.TabIndex = 10;
            btnCanItem.Text = "Cancelar Item\r\n(F1)";
            btnCanItem.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(54, 63, 84);
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(82, 481);
            button2.Name = "button2";
            button2.Size = new Size(73, 81);
            button2.TabIndex = 11;
            button2.Text = "Consultar Produto\r\n(F2)";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnFimVenda
            // 
            btnFimVenda.BackColor = Color.FromArgb(54, 63, 84);
            btnFimVenda.Dock = DockStyle.Fill;
            btnFimVenda.FlatStyle = FlatStyle.Flat;
            btnFimVenda.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFimVenda.ForeColor = Color.White;
            btnFimVenda.Location = new Point(240, 481);
            btnFimVenda.Name = "btnFimVenda";
            btnFimVenda.Size = new Size(76, 81);
            btnFimVenda.TabIndex = 12;
            btnFimVenda.Text = "Finalizar Venda\r\n(F4)";
            btnFimVenda.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(54, 63, 84);
            button5.Dock = DockStyle.Fill;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(161, 481);
            button5.Name = "button5";
            button5.Size = new Size(73, 81);
            button5.TabIndex = 14;
            button5.Text = "Adicionar CPF\r\n(F3)";
            button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(200, 212, 225);
            label2.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(336, 606);
            label2.Name = "label2";
            label2.Size = new Size(152, 56);
            label2.TabIndex = 15;
            label2.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(46, 51, 73);
            label3.Location = new Point(392, 90);
            label3.Name = "label3";
            label3.Size = new Size(223, 29);
            label3.TabIndex = 16;
            label3.Text = "Nome do Produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(46, 51, 73);
            label4.Location = new Point(784, 90);
            label4.Name = "label4";
            label4.Size = new Size(152, 29);
            label4.TabIndex = 17;
            label4.Text = "Quantidade:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.Location = new Point(479, 608);
            lbTotal.Name = "lbTotal";
            lbTotal.RightToLeft = RightToLeft.Yes;
            lbTotal.Size = new Size(145, 56);
            lbTotal.TabIndex = 18;
            lbTotal.Text = "00.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(46, 51, 73);
            label6.Location = new Point(1125, 90);
            label6.Name = "label6";
            label6.Size = new Size(86, 29);
            label6.TabIndex = 19;
            label6.Text = "Preço:";
            // 
            // btnFimSessao
            // 
            btnFimSessao.BackColor = Color.FromArgb(54, 63, 84);
            btnFimSessao.Dock = DockStyle.Fill;
            btnFimSessao.FlatStyle = FlatStyle.Flat;
            btnFimSessao.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFimSessao.ForeColor = Color.White;
            btnFimSessao.Location = new Point(240, 568);
            btnFimSessao.Name = "btnFimSessao";
            btnFimSessao.Size = new Size(76, 82);
            btnFimSessao.TabIndex = 20;
            btnFimSessao.Text = "Finalizar Sessão\r\n(F8)";
            btnFimSessao.UseVisualStyleBackColor = false;
            btnFimSessao.Click += btnFimSessao_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(54, 63, 84);
            button6.Dock = DockStyle.Fill;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(3, 568);
            button6.Name = "button6";
            button6.Size = new Size(73, 82);
            button6.TabIndex = 21;
            button6.Text = "Consultar Pagamento(F4)";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(54, 63, 84);
            button7.Dock = DockStyle.Fill;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(161, 568);
            button7.Name = "button7";
            button7.Size = new Size(73, 82);
            button7.TabIndex = 22;
            button7.Text = "Resumo Diário(F7)";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(54, 63, 84);
            button8.Dock = DockStyle.Fill;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(82, 568);
            button8.Name = "button8";
            button8.Size = new Size(73, 82);
            button8.TabIndex = 23;
            button8.Text = "Troca de Operador\n(F6)";
            button8.UseVisualStyleBackColor = false;
            // 
            // pnlSub
            // 
            pnlSub.BackColor = Color.FromArgb(200, 212, 225);
            pnlSub.Controls.Add(panel4);
            pnlSub.Controls.Add(panel1);
            pnlSub.Controls.Add(panel5);
            pnlSub.Controls.Add(panel2);
            pnlSub.Controls.Add(mtxtPes);
            pnlSub.Controls.Add(dgvPes);
            pnlSub.Controls.Add(label3);
            pnlSub.Controls.Add(label4);
            pnlSub.Controls.Add(label6);
            pnlSub.Controls.Add(lbTotal);
            pnlSub.Dock = DockStyle.Fill;
            pnlSub.Location = new Point(0, 0);
            pnlSub.Name = "pnlSub";
            pnlSub.Size = new Size(1264, 681);
            pnlSub.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(11, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 653);
            panel4.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(200, 212, 225);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnFimSessao, 3, 2);
            tableLayoutPanel1.Controls.Add(btnCanItem, 0, 1);
            tableLayoutPanel1.Controls.Add(btnFimVenda, 3, 1);
            tableLayoutPanel1.Controls.Add(button7, 2, 2);
            tableLayoutPanel1.Controls.Add(button2, 1, 1);
            tableLayoutPanel1.Controls.Add(button5, 2, 1);
            tableLayoutPanel1.Controls.Add(button8, 1, 2);
            tableLayoutPanel1.Controls.Add(button6, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.211586F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.394206F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.394206F));
            tableLayoutPanel1.Size = new Size(319, 653);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 63, 84);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(11, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 14);
            panel1.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 680);
            panel3.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(54, 63, 84);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(11, 667);
            panel5.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(54, 63, 84);
            panel2.Controls.Add(panel8);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 667);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 14);
            panel2.TabIndex = 20;
            // 
            // panel8
            // 
            panel8.Location = new Point(3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 680);
            panel8.TabIndex = 3;
            // 
            // mtxtPes
            // 
            mtxtPes.BackColor = SystemColors.Control;
            mtxtPes.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtPes.HidePromptOnLeave = true;
            mtxtPes.Location = new Point(336, 43);
            mtxtPes.Name = "mtxtPes";
            mtxtPes.Size = new Size(906, 43);
            mtxtPes.TabIndex = 10;
            mtxtPes.TextAlign = HorizontalAlignment.Right;
            // 
            // Subtotal
            // 
            ClientSize = new Size(1264, 681);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel7);
            Controls.Add(pnlSub);
            Name = "Subtotal";
            ((System.ComponentModel.ISupportInitialize)dgvPes).EndInit();
            pnlSub.ResumeLayout(false);
            pnlSub.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel7;
        private Label label1;
        private TextBox txtPesq;
        private DataGridView dgvPes;
        private Button btnCanItem;
        private Button button2;
        private Button btnFimVenda;
        private Button button5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbTotal;
        private Label label6;
        private Button btnFimSessao;
        private Button button6;
        private Button button7;
        private Button button8;
        private Panel pnlSub;
        private MaskedTextBox mtxtPes;
        private Panel panel2;
        private Panel panel8;
        private Panel panel5;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
    }
}