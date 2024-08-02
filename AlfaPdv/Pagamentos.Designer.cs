using System.Windows.Forms;

namespace AlfaPdv
{
    partial class Paga
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
            dgvPag = new DataGridView();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPag).BeginInit();
            SuspendLayout();
            // 
            // dgvPag
            // 
            dgvPag.AllowUserToAddRows = false;
            dgvPag.AllowUserToDeleteRows = false;
            dgvPag.AllowUserToResizeColumns = false;
            dgvPag.AllowUserToResizeRows = false;
            dgvPag.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPag.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgvPag.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(80, 56, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPag.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPag.GridColor = Color.White;
            dgvPag.Location = new Point(60, 139);
            dgvPag.MultiSelect = false;
            dgvPag.Name = "dgvPag";
            dgvPag.ReadOnly = true;
            dgvPag.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPag.RowHeadersVisible = false;
            dgvPag.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPag.RowTemplate.Height = 25;
            dgvPag.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPag.Size = new Size(1139, 490);
            dgvPag.TabIndex = 0;
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
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(46, 23);
            button1.TabIndex = 4;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(46, 50);
            label1.Name = "label1";
            label1.Size = new Size(514, 55);
            label1.TabIndex = 10;
            label1.Text = "Formas de Pagamento";
            // 
            // button2
            // 
            button2.Location = new Point(1094, 62);
            button2.Name = "button2";
            button2.Size = new Size(105, 42);
            button2.TabIndex = 11;
            button2.Text = "Desmarcar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(983, 63);
            button3.Name = "button3";
            button3.Size = new Size(105, 42);
            button3.TabIndex = 12;
            button3.Text = "Apagar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(872, 62);
            button4.Name = "button4";
            button4.Size = new Size(105, 42);
            button4.TabIndex = 13;
            button4.Text = "Alterar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(761, 63);
            button5.Name = "button5";
            button5.Size = new Size(105, 42);
            button5.TabIndex = 14;
            button5.Text = "Adicionar";
            button5.UseVisualStyleBackColor = true;
            // 
            // Paga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1264, 681);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(dgvPag);
            Name = "Paga";
            Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)dgvPag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPag;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}