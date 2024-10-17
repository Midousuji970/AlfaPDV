using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlfaPdv
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            InitializeButton();

        }

        private void InitializeButton()
        {
            // Configura o evento Click do botão
            btnProd.Click += new EventHandler(btnProd_Click);
            btnFun.Click += new EventHandler(btnFun_Click);
            btnSessao.Click += new EventHandler(btnSessao_Click);
        }

        private void ini_Load(object sender, EventArgs e)
        {
            // Calcule a posição central para o Label j
            //int labelWidth = lblVenda.Width;
            //int labelHeight = lblVenda.Height;
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Defina a posição do Label para centralizá-lo
            //lblVenda.Location = new Point((formWidth - labelWidth) / 2, (formHeight - labelHeight) / 2);
        }
        private void btnProd_Click(object sender, EventArgs e)
        {
            LoadItemProdForm();
        }

        private void btnCli_Click(object sender, EventArgs e)
        {
            // Implementar evento btnCli_Click
        }

        private void btnFun_Click(object sender, EventArgs e)
        {
            LoadCadFun();
        }

        private void LoadItemProdForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control != pnlini)
                {
                    control.Visible = false;
                }
            }
            pnlini.Controls.Clear();
            AlfaPdv.Produto ProdutoForm = new AlfaPdv.Produto();
            ProdutoForm.TopLevel = false;
            ProdutoForm.FormBorderStyle = FormBorderStyle.None;
            ProdutoForm.Dock = DockStyle.Fill;
            pnlini.Controls.Add(ProdutoForm);
            ProdutoForm.Show();
        }

        private void LoadCadFun()
        {
            foreach (Control control in this.Controls)
            {
                if (control != pnlini)
                {
                    control.Visible = false;
                }
            }
            pnlini.Controls.Clear();
            AlfaPdv.Funcionario FuncionarioForm = new AlfaPdv.Funcionario();
            FuncionarioForm.TopLevel = false;
            FuncionarioForm.FormBorderStyle = FormBorderStyle.None;
            FuncionarioForm.Dock = DockStyle.Fill;
            pnlini.Controls.Add(FuncionarioForm);
            FuncionarioForm.Show();
        }

        private void btnSessao_Click(object sender, EventArgs e)
        {
            LoadSessao();
        }

        private void LoadSessao()
        {
            foreach (Control control in this.Controls)
            {
                if (control != pnlini)
                {
                    control.Visible = false;
                }
            }
            pnlini.Controls.Clear();
            AlfaPdv.PDV.Subtotal SubForm = new AlfaPdv.PDV.Subtotal();
            SubForm.TopLevel = false;
            SubForm.FormBorderStyle = FormBorderStyle.None;
            SubForm.Dock = DockStyle.Fill;
            pnlini.Controls.Add(SubForm);
            SubForm.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
