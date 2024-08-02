using AlfaPdv.Classes;
using AlfaPdv.Services;
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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            InitializeButton();
            InitializeDVGProd();
            
        }

        private void InitializeButton()
        {
            // Configura o evento Click do botão
            bntVoltaIni.Click += new EventHandler(bntVoltaIni_Click);
        }

        private void bntVoltaIni_Click(object sender, EventArgs e)
        {
            LoadIniForm();
        }

        private void LoadIniForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control != pnlCadProd)
                {
                    control.Visible = false;
                }
            }

            pnlCadProd.Controls.Clear();

            AlfaPdv.Inicio InicioForm = new AlfaPdv.Inicio();

            InicioForm.TopLevel = false;
            InicioForm.FormBorderStyle = FormBorderStyle.None;
            InicioForm.Dock = DockStyle.Fill;
            pnlCadProd.Controls.Add(InicioForm);
            InicioForm.Show();
             
        }
       private async void InitializeDVGProd()
        {
            VerProd verProd = new VerProd();
            try
            {
                ProdServices VerProd = new ProdServices();

                List<VerProd> data = await VerProd.Produ();
                dgvProd.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter os dados: " + ex.Message);
            }
        }
    }
}
