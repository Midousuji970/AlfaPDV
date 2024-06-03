using AlfaPdv.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlfaPdv.Item
{
    public partial class ItemFun : Form
    {
        public ItemFun()
        {
            InitializeComponent();
            InitializeButton();
            var verifica = Envio.Verifica;
            if (verifica == 1)
            {
                var id = Envio.Fun;
                var nome = Envio.FunNome;
                var cargo = Envio.FunCargo;
               
                txtBoxFun.Text = id.ToString();
                txtBoxNome.Text = nome;
                txtBoxCargo.Text = cargo;
            }
            else
            {
                var adId = Envio.Fun;
                txtBoxFun.Text = adId.ToString();
            }
        }

        private void InitializeButton()
        {
            btnVolCadFun.Click += new EventHandler(btnVolCadFun_Click);
        }

        
        private void btnVolCadFun_Click(object sender, EventArgs e)
        {
            LoadCadProd();
        }

        private void LoadCadProd()
        {
            foreach (Control control in this.Controls)
            {
                if (control != pnlItemFun)
                {
                    control.Visible = false;
                }
            }

            pnlItemFun.Controls.Clear();
            AlfaPdv.Funcionario FuncionarioForm = new AlfaPdv.Funcionario();
            FuncionarioForm.TopLevel = false;
            FuncionarioForm.FormBorderStyle = FormBorderStyle.None;
            FuncionarioForm.Dock = DockStyle.Fill;
            pnlItemFun.Controls.Add(FuncionarioForm);
            FuncionarioForm.Show();


        }

    }
}
