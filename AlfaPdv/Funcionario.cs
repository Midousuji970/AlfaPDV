using AlfaPdv.Classes;
using AlfaPdv.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }
        private async void InitializeDVG()
        {
            VerFun verFun = new VerFun();
            try
            {
                FunServices VerFun = new FunServices();

                List<VerFun> data = await VerFun.Integra();
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
        private void btnFunAdi_Click(object sender, EventArgs e) {
            LoadAdiForm();
        }
        private void btnFunAlt_Click(object sender, EventArgs e) {
            LoadAltForm();
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
                int ultId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
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
        private void LoadAltForm()
        {
            if (dgvFun.SelectedRows.Count > 0) {
             
            DataGridViewRow selectedRow = dgvFun.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            string nome = selectedRow.Cells["Nome"].Value.ToString();
            string cargo = selectedRow.Cells["Cargo"].Value.ToString();
            int verifica = 1;

            Envio.Fun = id;
            Envio.FunNome = nome;
            Envio.FunCargo = cargo; 
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
}
