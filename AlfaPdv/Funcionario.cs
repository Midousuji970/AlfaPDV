using AlfaPdv.Classes;
using AlfaPdv.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlfaPdv
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            InitializeDVG();
            InitializeButton();

        }

        private void InitializeButton()
        {
            // Configura o evento Click do botão
            btnVoltaIni.Click += new EventHandler(btnVoltaIni_Click);
            btnFunAdi.Click += new EventHandler(btnFunAdi_Click);
            btnFunAlt.Click += new EventHandler(btnFunAlt_Click);
            btnFunEra.Click += new EventHandler(btnFunEra_Click);


        }
        private async void InitializeDVG()
        {
            try
            {
                FunServices funServices = new FunServices();
                DataTable data = await funServices.Integra();
                dgvFun.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter os dados: " + ex.Message);
            }
        }

        private void btnVoltaIni_Click(object sender, EventArgs e)
        {
            LoadIniForm();
        }
        private void btnFunAdi_Click(object sender, EventArgs e)
        {
            LoadAdiForm();
        }
        private void btnFunAlt_Click(object sender, EventArgs e)
        {
            LoadAltForm();

        }
        private void btnFunEra_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void LoadIniForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control != pnlCadFun)
                {
                    control.Visible = false;
                }
            }

            pnlCadFun.Controls.Clear();

            AlfaPdv.Inicio InicioForm = new AlfaPdv.Inicio();

            InicioForm.TopLevel = false;
            InicioForm.FormBorderStyle = FormBorderStyle.None;
            InicioForm.Dock = DockStyle.Fill;
            pnlCadFun.Controls.Add(InicioForm);
            InicioForm.Show();

        }

        private void LoadAdiForm()

        {
            int ultimaLinha = dgvFun.Rows.Count - 1;
            dgvFun.Rows[ultimaLinha].Selected = true;
            if (dgvFun.SelectedRows.Count > 0)
            {
                // Obtém a última linha selecionada
                DataGridViewRow selectedRow = dgvFun.SelectedRows[dgvFun.SelectedRows.Count - 1];

                // Obtém os valores das células da última linha
                int ultId = Convert.ToInt32(selectedRow.Cells["funId"].Value);
                int newId = ultId + 1;
                Envio.Verifica = 0;

                Envio.Fun = newId;
            }
            foreach (Control control in this.Controls)
            {
                if (control != pnlCadFun)
                {
                    control.Visible = false;
                }
            }

            pnlCadFun.Controls.Clear();

            AlfaPdv.Item.ItemFun ItemFunForm = new AlfaPdv.Item.ItemFun();

            ItemFunForm.TopLevel = false;
            ItemFunForm.FormBorderStyle = FormBorderStyle.None;
            ItemFunForm.Dock = DockStyle.Fill;
            pnlCadFun.Controls.Add(ItemFunForm);
            ItemFunForm.Show();

        }
        private async Task FunFull(int id)
        {

            FunCompleto funCompleto = new FunCompleto();
            try
            {

                FunServices FunCompleto = new FunServices();
                FunCompleto dataCompleto = await FunCompleto.FunFullIntegra(id);

                Envio.FunNome = dataCompleto.funNome;
                Envio.FunCpf = dataCompleto.funCpf.ToString(); // Deveria estar correto
                Envio.Ende = dataCompleto.funEnd; // Provavelmente deveria ser funEnd
                Envio.Num = dataCompleto.funEndNum.ToString(); // Deveria estar correto
                Envio.FunCargo = dataCompleto.funCargo.ToString(); // Deveria estar correto
                Envio.Tele = dataCompleto.funTele.ToString(); // Deveria estar correto
                Envio.Email = dataCompleto.funMail;
                Envio.Datas = dataCompleto.funDataEnt.ToString();

            }
            catch (Exception ex) { }


        }
        
        private async void LoadAltForm()
        {
            if (dgvFun.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvFun.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                Envio.Fun = id;
                int verifica = 1;
                await FunFull(id);
                var teste = 0;
                if (teste != 1)
                {

                    Envio.Verifica = verifica;

                    foreach (Control control in this.Controls)
                    {
                        if (control != pnlCadFun)
                        {
                            control.Visible = false;
                        }
                    }

                    pnlCadFun.Controls.Clear();

                    AlfaPdv.Item.ItemFun ItemFunForm = new AlfaPdv.Item.ItemFun();

                    ItemFunForm.TopLevel = false;
                    ItemFunForm.FormBorderStyle = FormBorderStyle.None;
                    ItemFunForm.Dock = DockStyle.Fill;
                    pnlCadFun.Controls.Add(ItemFunForm);
                    ItemFunForm.Show();
                }
                else
                {
                    MessageBox.Show("Selecione um Funcionario!");
                }

            }


        }
        private async void DeleteItem()
        {
            if (dgvFun.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFun.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nome = Convert.ToString(selectedRow.Cells["nome"].Value);

                FunServices funServices = new FunServices();
                try
                {
                    await funServices.Remover(id, nome);
                    
                    ReiniDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover funcionário: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para remover.");
            }
        }

        private void ReiniDGV()
        {
            InitializeDVG();
        }

    }
}
