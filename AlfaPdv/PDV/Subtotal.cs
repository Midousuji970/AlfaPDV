using AlfaPdv.Classes;
using AlfaPdv.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlfaPdv.PDV
{
    public partial class Subtotal : Form
    {
        private ProdServices prodServices = new ProdServices();

        public Subtotal()
        {
            InitializeComponent();
            InitializeButton();
            InitializeDataGridView();
            mtxtPes.PromptChar = ' ';
        }

        public Subtotal(List<string> produtos)
        {
            InitializeComponent();
            InitializeButton();
            InitializeDataGridView();
            mtxtPes.PromptChar = ' ';
            CarregarProdutos(produtos);
        }

        private void InitializeButton()
        {
            //btnFimSessao.Click += new EventHandler(btnFimSessao_Click);
            this.Shown += new EventHandler(Form_Shown);
            mtxtPes.KeyPress += new KeyPressEventHandler(mtxtPes_KeyPress);
            //btnFimVenda.Click += new EventHandler(btnFimVenda_Click);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Subtotal_KeyDown);
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            mtxtPes.Focus();
            mtxtPes.Select();
        }

        private void Subtotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                FinalizarVenda();
            }
        }

        private void mtxtPes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '*' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                _ = BuscarProduto();
                mtxtPes.Clear();
            }
        }

        private async Task BuscarProduto()
        {
            try
            {
                string input = mtxtPes.Text;
                int quantidade = 1;
                int codigo;

                if (input.Contains('*'))
                {
                    string[] parts = input.Split('*');
                    if (parts.Length == 2 && int.TryParse(parts[0], out quantidade) && int.TryParse(parts[1], out codigo))
                    {
                        VerProd produto = await prodServices.BuscarProduto(codigo);

                        if (produto != null)
                        {
                            AdicionarProdutoNoDataGridView(produto, quantidade);
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formato inválido! Use quantidade*código.");
                    }
                }
                else if (int.TryParse(input, out codigo))
                {
                    VerProd produto = await prodServices.BuscarProduto(codigo);

                    if (produto != null)
                    {
                        AdicionarProdutoNoDataGridView(produto, quantidade);
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado!");
                    }
                }
                else
                {
                    MessageBox.Show("Código inválido!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto: " + ex.Message);
            }
        }

        private void AdicionarProdutoNoDataGridView(VerProd produto, int quantidade)
        {
            if (double.TryParse(produto.Preco, out double preco))
            {
                double precoTotal = preco * quantidade;
                string precostring = precoTotal.ToString("F2");
                dgvPes.Columns.Add(produto.Nome, quantidade);
                AtualizarTotal();
            }
            else
            {
                MessageBox.Show("Preço do produto inválido!");
            }
        }

        private void AtualizarTotal()
        {
            double total = 0;

            foreach (DataGridViewRow row in dgvPes.Columns)
            {
                if (row.Cells["Preco"].Value != null)
                {
                    double.TryParse(row.Cells["Preco"].Value.ToString(), out double preco);


                    total += preco;

                }
            }

            lbTotal.Text = "" + total.ToString("F2");
        }

        private void InitializeDataGridView()
        {
            dgvPes.Columns.Clear();
            dgvPes.Columns.Add("Nome", "Nome do Produto");
            dgvPes.Columns.Add("Quantidade", "Quantidade");
            dgvPes.Columns.Add("Preco", "Preço");
        }

        private void CarregarProdutos(List<string> produtos)
        {
            foreach (var produto in produtos)
            {
                string[] dados = produto.Split('-');
                if (dados.Length == 3)
                {
                    string nome = dados[0].Trim();
                    int quantidade = int.Parse(dados[1].Trim());
                    double preco = double.Parse(dados[2].Trim());
                    ListViewItem item = new ListViewItem(nome);
                    item.SubItems.Add(quantidade.ToString());
                    item.SubItems.Add(preco.ToString());
                }
            }
            AtualizarTotal();
        }

        private void btnFimSessao_Click(object sender, EventArgs e)
        {
            // Código do evento btnFimSessao_Click
        }

        private void btnFimVenda_Click(object sender, EventArgs e)
        {
            FinalizarVenda();
        }

        private void FinalizarVenda()
        {
            if (dgvPes.Items.Count > 0)
            {
                List<string> produtos = new List<string>();

                foreach (ListViewItem item in dgvPes.Items)
                {
                    string nome = item.SubItems[0].Text; // Nome está na primeira coluna
                    string quantidade = item.SubItems[1].Text; // Quantidade está na segunda coluna
                    string preco = item.SubItems[2].Text; // Preço está na terceira coluna

                    produtos.Add($"{nome} - {quantidade} - {preco}");
                }

                Finalizacao finalizacaoForm = new Finalizacao(produtos, lbTotal.Text);
                LoadFormInPanel(finalizacaoForm);
            }
            else
            {
                MessageBox.Show("Não há produtos no carrinho para finalizar a venda.");
            }
        }

        private void LoadFormInPanel(Form form)
        {
            foreach (Control control in this.Parent.Controls)
            {
                if (control != this.Parent)
                {
                    control.Visible = false;
                }
            }

            Panel parentPanel = this.Parent as Panel;
            parentPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(form);
            form.Show();
        }

    }
}
