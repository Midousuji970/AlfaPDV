namespace AlfaPdv
{
    partial class Funcionario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvFun = new DataGridView();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            btnVoltaIni = new Button();
            label1 = new Label();
            btnFunEra = new Button();
            btnFunAlt = new Button();
            btnFunAdi = new Button();
            pnlCadFun = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvFun).BeginInit();
            pnlCadFun.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFun
            // 
            dgvFun.AllowUserToAddRows = false;
            dgvFun.AllowUserToDeleteRows = false;
            dgvFun.AllowUserToResizeColumns = false;
            dgvFun.AllowUserToResizeRows = false;
            dgvFun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFun.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgvFun.BorderStyle = BorderStyle.None;
            dgvFun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(80, 56, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvFun.DefaultCellStyle = dataGridViewCellStyle1;
            dgvFun.GridColor = Color.White;
            dgvFun.Location = new Point(60, 139);
            dgvFun.MultiSelect = false;
            dgvFun.Name = "dgvFun";
            dgvFun.ReadOnly = true;
            dgvFun.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFun.RowHeadersVisible = false;
            dgvFun.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvFun.RowTemplate.Height = 25;
            dgvFun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFun.Size = new Size(1139, 490);
            dgvFun.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(363, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(836, 23);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Codigo", "Descriçao", "Preço", "Estoque" });
            comboBox1.Location = new Point(60, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 23);
            comboBox1.TabIndex = 3;
            // 
            // btnVoltaIni
            // 
            btnVoltaIni.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltaIni.Location = new Point(12, 12);
            btnVoltaIni.Name = "btnVoltaIni";
            btnVoltaIni.Size = new Size(46, 23);
            btnVoltaIni.TabIndex = 4;
            btnVoltaIni.Text = "Voltar";
            btnVoltaIni.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(46, 50);
            label1.Name = "label1";
            label1.Size = new Size(551, 55);
            label1.TabIndex = 10;
            label1.Text = "Cadastro de Funcionario";
            // 
            // btnFunEra
            // 
            btnFunEra.Location = new Point(1093, 61);
            btnFunEra.Name = "btnFunEra";
            btnFunEra.Size = new Size(105, 42);
            btnFunEra.TabIndex = 12;
            btnFunEra.Text = "Apagar";
            btnFunEra.UseVisualStyleBackColor = true;
            btnFunEra.Click += btnFunEra_Click;
            // 
            // btnFunAlt
            // 
            btnFunAlt.Location = new Point(982, 61);
            btnFunAlt.Name = "btnFunAlt";
            btnFunAlt.Size = new Size(105, 42);
            btnFunAlt.TabIndex = 13;
            btnFunAlt.Text = "Alterar";
            btnFunAlt.UseVisualStyleBackColor = true;
            // 
            // btnFunAdi
            // 
            btnFunAdi.Location = new Point(871, 61);
            btnFunAdi.Name = "btnFunAdi";
            btnFunAdi.Size = new Size(105, 42);
            btnFunAdi.TabIndex = 14;
            btnFunAdi.Text = "Adicionar";
            btnFunAdi.UseVisualStyleBackColor = true;
            // 
            // pnlCadFun
            // 
            pnlCadFun.BorderStyle = BorderStyle.FixedSingle;
            pnlCadFun.Controls.Add(btnFunAdi);
            pnlCadFun.Controls.Add(btnFunEra);
            pnlCadFun.Controls.Add(btnFunAlt);
            pnlCadFun.Dock = DockStyle.Fill;
            pnlCadFun.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pnlCadFun.ForeColor = SystemColors.ControlText;
            pnlCadFun.Location = new Point(0, 0);
            pnlCadFun.Name = "pnlCadFun";
            pnlCadFun.Size = new Size(1264, 681);
            pnlCadFun.TabIndex = 15;
            // 
            // Funcionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1264, 681);
            Controls.Add(label1);
            Controls.Add(btnVoltaIni);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(dgvFun);
            Controls.Add(pnlCadFun);
            Name = "Funcionario";
            Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)dgvFun).EndInit();
            pnlCadFun.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFun;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button btnVoltaIni;
        private Label label1;
        private Button btnFunEra;
        private Button btnFunAlt;
        private Button btnFunAdi;
        private Panel pnlCadFun;
    }
}