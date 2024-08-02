using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AlfaPdv.PDV
{
    public partial class Finalizacao : Form
    {
        private List<string> produtos;
        private double total;
        private double troco;
        private List<Pagamento> pagamentos;

        public Finalizacao(List<string> produtos, string total)
        {
            InitializeComponent();
            this.produtos = produtos;
            this.total = double.Parse(total);
            this.pagamentos = new List<Pagamento>();
            CarregarProdutos();
            string Total = "Total: ";
            lbTotal.Text = Total + this.total.ToString("F2");
            InitializeControls();
        }

        private void CarregarProdutos()
        {
            foreach (var produto in produtos)
            {
                var detalhes = produto.Split('-');
                if (detalhes.Length == 3)
                {
                    string nome = detalhes[0].Trim();
                    string quantidade = detalhes[1].Trim();
                    string preco = detalhes[2].Trim();

                    ListBoxItem.Items.Add($"Nome: {nome}, Quantidade: {quantidade}, Preço: {preco}");
                }
            }
        }

        private void InitializeControls()
        {
            mtxtFina1.KeyPress += new KeyPressEventHandler(mtxtFina1_KeyPress);
            txtFina3.KeyPress += new KeyPressEventHandler(txtFina3_KeyPress);
            this.Shown += new EventHandler(Form_Shown);
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            mtxtFina1.Focus();
            mtxtFina1.Select();
        }

        private void mtxtFina1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Subtotal subtotalForm = new Subtotal(produtos);
                LoadFormInPanel(subtotalForm);
                return;
            }

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                switch (mtxtFina1.Text)
                {
                    case "1":
                        txtFina2.Text = "Dinheiro";
                        break;
                    case "2":
                        txtFina2.Text = "Crédito";
                        break;
                    case "3":
                        txtFina2.Text = "Débito";
                        break;
                    default:
                        MessageBox.Show("Opção inválida! Escolha 1, 2 ou 3.");
                        mtxtFina1.Clear();
                        mtxtFina1.Focus();
                        return;
                }
                txtFina3.Text = total.ToString("F2");
                txtFina3.Focus();
                txtFina3.Select();
            }
        }

        private void txtFina3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;

                if (double.TryParse(txtFina3.Text, out double valorRecebido))
                {
                    Pagamento pagamento = new Pagamento
                    {
                        IdMetodoPagamento = mtxtFina1.Text,
                        DescricaoPagamento = txtFina2.Text,
                        ValorPagamento = valorRecebido,
                        Total = total
                    };
                    pagamentos.Add(pagamento);

                    if (valorRecebido < total)
                    {
                        total -= valorRecebido;
                        lbTotal.Text = "Total: " + total.ToString("F2");
                    }
                    else
                    {
                        troco = valorRecebido - total;
                        if(troco > total)
                        {

                        }
                        total = 0;
                        lbTotal.Text = "Total: 0.00";
                        lbTroco.Text = "Troco: " + troco.ToString("F2");

                        int numeroRecibo = AtualizarNumeracaoRecibo();
                        SaveReceipt(numeroRecibo);
                        MessageBox.Show($"Compra finalizada! PDF Recibo{numeroRecibo} salvo na pasta Documentos.");
                        Subtotal subtotalForm = new Subtotal();
                        LoadFormInPanel(subtotalForm);
                        return;
                    }
                    mtxtFina1.Clear();
                    txtFina2.Clear();
                    txtFina3.Clear();
                    mtxtFina1.Focus();
                    mtxtFina1.Select();
                }
                else
                {
                    MessageBox.Show("Valor inválido!");
                    txtFina3.Clear();
                    txtFina3.Focus();
                    txtFina3.Select();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            List<string> produtosList = new List<string>();
            foreach (var item in ListBoxItem.Items)
            {
                produtosList.Add(item.ToString());
            }

            Subtotal subtotalForm = new Subtotal(produtosList);
            LoadFormInPanel(subtotalForm);
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

        private int AtualizarNumeracaoRecibo()
        {
            string path = @"C:\Program Files\numRecibo\numeracao";
            int numeroRecibo = 0;

            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    var obj = JsonConvert.DeserializeObject<JObject>(json);
                    numeroRecibo = obj["id"].Value<int>() + 1;
                    obj["id"] = numeroRecibo;
                    File.WriteAllText(path, obj.ToString(Formatting.None));
                }
                else
                {
                    var obj = new JObject { ["id"] = 1 };
                    numeroRecibo = 1;
                    File.WriteAllText(path, obj.ToString(Formatting.None));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar a numeração do recibo: {ex.Message}");
            }

            return numeroRecibo;
        }

        private void SaveReceipt(int numeroRecibo)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(documentsPath, $"Recibo{numeroRecibo}.pdf");

            PdfDocument document = new PdfDocument();
            document.Info.Title = $"Recibo {numeroRecibo}";

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 12);

            int yPoint = 0;

            gfx.DrawString($"Recibo - {numeroRecibo}", font, XBrushes.Black, new XRect(0, yPoint, page.Width, page.Height), XStringFormats.TopCenter);
            yPoint += 40;

            gfx.DrawString("Produtos:", font, XBrushes.Black, new XRect(40, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += 20;

            foreach (var produto in produtos)
            {
                var detalhes = produto.Split('-');
                if (detalhes.Length == 3)
                {
                    string nome = detalhes[0].Trim();
                    string quantidade = detalhes[1].Trim();
                    string preco = detalhes[2].Trim();

                    gfx.DrawString($"Nome: {nome}, Quantidade: {quantidade}, Preço: {preco}", font, XBrushes.Black, new XRect(40, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                    yPoint += 20;
                }
            }

            yPoint += 20;
            gfx.DrawString("Pagamentos:", font, XBrushes.Black, new XRect(40, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += 20;

            foreach (var pagamento in pagamentos)
            {
                gfx.DrawString($"ID: {pagamento.IdMetodoPagamento}, Descrição: {pagamento.DescricaoPagamento}, Valor: {pagamento.ValorPagamento.ToString("F2")}, Total: {pagamento.Total.ToString("F2")}", font, XBrushes.Black, new XRect(40, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                yPoint += 20;
            }

            yPoint += 20;
            gfx.DrawString($"Total Pago: {(pagamentos[pagamentos.Count - 1].Total - troco).ToString("F2")}", font, XBrushes.Black, new XRect(40, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Troco Devolvido: {troco.ToString("F2")}", font, XBrushes.Black, new XRect(40, yPoint + 20, page.Width, page.Height), XStringFormats.TopLeft);

            document.Save(filePath);
        }
    }

    public class Pagamento
    {
        public string IdMetodoPagamento { get; set; }
        public string DescricaoPagamento { get; set; }
        public double ValorPagamento { get; set; }
        public double Total { get; set; }
    }
}
