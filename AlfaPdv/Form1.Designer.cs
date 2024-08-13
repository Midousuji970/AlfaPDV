namespace AlfaPdv
{
    partial class ALFAPDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ALFAPDV));
            txtB1 = new TextBox();
            txtB3 = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtB1
            // 
            txtB1.BackColor = Color.White;
            txtB1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtB1.ForeColor = Color.Black;
            txtB1.Location = new Point(42, 29);
            txtB1.Name = "txtB1";
            txtB1.PlaceholderText = "Código de Usuário";
            txtB1.RightToLeft = RightToLeft.No;
            txtB1.Size = new Size(332, 25);
            txtB1.TabIndex = 0;
            txtB1.KeyPress += txtB1_KeyPress;
            // 
            // txtB3
            // 
            txtB3.BackColor = Color.White;
            txtB3.Cursor = Cursors.IBeam;
            txtB3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtB3.ForeColor = Color.Black;
            txtB3.Location = new Point(42, 60);
            txtB3.Name = "txtB3";
            txtB3.PasswordChar = '*';
            txtB3.PlaceholderText = "Senha";
            txtB3.RightToLeft = RightToLeft.No;
            txtB3.Size = new Size(332, 25);
            txtB3.TabIndex = 2;
            txtB3.KeyPress += txtB3_KeyPress;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(169, 101);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 25);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // ALFAPDV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(400, 138);
            Controls.Add(btnLogin);
            Controls.Add(txtB3);
            Controls.Add(txtB1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ALFAPDV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlfaPDV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtB1;
        private TextBox txtB3;
        private Button btnLogin;
    }
}
