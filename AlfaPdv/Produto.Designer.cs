using System.Windows.Forms;

namespace AlfaPdv
{
    partial class Produto
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
            dgvProd = new DataGridView();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            bntVoltaIni = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            pnlCadProd = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProd).BeginInit();
            pnlCadProd.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProd
            // 
            dgvProd.AllowUserToAddRows = false;
            dgvProd.AllowUserToDeleteRows = false;
            dgvProd.AllowUserToResizeColumns = false;
            dgvProd.AllowUserToResizeRows = false;
            dgvProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProd.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgvProd.BorderStyle = BorderStyle.None;
            dgvProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(80, 56, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProd.DefaultCellStyle = dataGridViewCellStyle1;
            dgvProd.GridColor = Color.White;
            dgvProd.Location = new Point(60, 139);
            dgvProd.MultiSelect = false;
            dgvProd.Name = "dgvProd";
            dgvProd.ReadOnly = true;
            dgvProd.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProd.RowHeadersVisible = false;
            dgvProd.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProd.RowTemplate.Height = 25;
            dgvProd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProd.Size = new Size(1139, 490);
            dgvProd.TabIndex = 0;
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
            comboBox1.Items.AddRange(new object[] { "Codigo", "Descriçao", "Preço", "Estoque" });
            comboBox1.Location = new Point(60, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 23);
            comboBox1.TabIndex = 3;
            // 
            // bntVoltaIni
            // 
            bntVoltaIni.Location = new Point(12, 12);
            bntVoltaIni.Name = "bntVoltaIni";
            bntVoltaIni.Size = new Size(46, 23);
            bntVoltaIni.TabIndex = 4;
            bntVoltaIni.Text = "Voltar";
            bntVoltaIni.UseVisualStyleBackColor = true;
            bntVoltaIni.Click += bntVoltaIni_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(46, 50);
            label1.Name = "label1";
            label1.Size = new Size(493, 55);
            label1.TabIndex = 10;
            label1.Text = "Cadastro de Produtos";
            // 
            // button3
            // 
            button3.Location = new Point(1094, 62);
            button3.Name = "button3";
            button3.Size = new Size(105, 42);
            button3.TabIndex = 12;
            button3.Text = "Apagar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(983, 62);
            button4.Name = "button4";
            button4.Size = new Size(105, 42);
            button4.TabIndex = 13;
            button4.Text = "Alterar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(872, 62);
            button5.Name = "button5";
            button5.Size = new Size(105, 42);
            button5.TabIndex = 14;
            button5.Text = "Adicionar";
            button5.UseVisualStyleBackColor = true;
            // 
            // pnlCadProd
            // 
            pnlCadProd.Controls.Add(button5);
            pnlCadProd.Controls.Add(button3);
            pnlCadProd.Controls.Add(button4);
            pnlCadProd.Dock = DockStyle.Fill;
            pnlCadProd.Location = new Point(0, 0);
            pnlCadProd.Name = "pnlCadProd";
            pnlCadProd.Size = new Size(1264, 681);
            pnlCadProd.TabIndex = 15;
            // 
            // Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1264, 681);
            Controls.Add(label1);
            Controls.Add(bntVoltaIni);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(dgvProd);
            Controls.Add(pnlCadProd);
            Name = "Produto";
            Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)dgvProd).EndInit();
            pnlCadProd.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProd;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button bntVoltaIni;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel pnlCadProd;
    }
}