using System.Windows.Forms;

namespace AlfaPdv
{
    partial class Proprio
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
            dgvPro = new DataGridView();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPro).BeginInit();
            SuspendLayout();
            // 
            // dgvPro
            // 
            dgvPro.AllowUserToAddRows = false;
            dgvPro.AllowUserToDeleteRows = false;
            dgvPro.AllowUserToResizeColumns = false;
            dgvPro.AllowUserToResizeRows = false;
            dgvPro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPro.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgvPro.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(80, 56, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPro.GridColor = Color.White;
            dgvPro.Location = new Point(60, 139);
            dgvPro.MultiSelect = false;
            dgvPro.Name = "dgvPro";
            dgvPro.ReadOnly = true;
            dgvPro.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPro.RowHeadersVisible = false;
            dgvPro.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPro.RowTemplate.Height = 25;
            dgvPro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPro.Size = new Size(1139, 490);
            dgvPro.TabIndex = 0;
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
            label1.Size = new Size(388, 55);
            label1.TabIndex = 10;
            label1.Text = "Cadastro Próprio";
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
            // Proprio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1264, 681);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(dgvPro);
            Name = "Proprio";
            Text = "AlfaPDV";
            ((System.ComponentModel.ISupportInitialize)dgvPro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPro;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button4;
        private Button button5;
    }
}