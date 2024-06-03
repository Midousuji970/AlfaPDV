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
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            LoadItemProdForm();

        }


        private void btnCli_Click(object sender, EventArgs e)
        {

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
            // Limpa os controles do panelContainer
            pnlini.Controls.Clear();

            // Cria uma instância do formulário ItemProd
            AlfaPdv.Produto ProdutoForm = new AlfaPdv.Produto();

            // Define o formulário ItemProd como não TopLevel
            ProdutoForm.TopLevel = false;

            // Remove bordas do formulário
            ProdutoForm.FormBorderStyle = FormBorderStyle.None;

            // Define o formulário para preencher todo o painel
            ProdutoForm.Dock = DockStyle.Fill;

            // Adiciona o formulário ItemProd ao panelContainer
            pnlini.Controls.Add(ProdutoForm);

            // Exibe o formulário ItemProd
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
            // Limpa os controles do panelContainer
            pnlini.Controls.Clear();

            // Cria uma instância do formulário ItemProd
            AlfaPdv.Funcionario FuncionarioForm = new AlfaPdv.Funcionario();

            // Define o formulário ItemProd como não TopLevel
            FuncionarioForm.TopLevel = false;

            // Remove bordas do formulário
            FuncionarioForm.FormBorderStyle = FormBorderStyle.None;

            // Define o formulário para preencher todo o painel
            FuncionarioForm.Dock = DockStyle.Fill;

            // Adiciona o formulário ItemProd ao panelContainer
            pnlini.Controls.Add(FuncionarioForm);

            // Exibe o formulário ItemProd
            FuncionarioForm.Show();

        }
    }

}
