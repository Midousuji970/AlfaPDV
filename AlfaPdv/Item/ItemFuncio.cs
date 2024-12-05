using AlfaPdv.Classes;
using AlfaPdv.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
                var end = Envio.Ende;
                var cep = Envio.Cep;
                var cpf = Envio.FunCpf;
                var email = Envio.Email;
                var data = Envio.Datas;
                var tele = Envio.Tele;
                var num = Envio.Num;

                txtBoxFun.Text = id.ToString();
                txtBoxNome.Text = nome;
                txtBoxCargo.Text = cargo;
                txtBoxEnd.Text = end;
                txtBoxCep.Text = cep;
                txtBoxDate.Text = data;
                txtBoxCpf.Text = cpf;
                txtBoxMail.Text = email;
                txtBoxTele.Text = tele;
                txtBoxEndNum.Text = num;

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
            btnFunOk.Click += new EventHandler(btnFunOk_Click);

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

        private async void btnFunOk_Click(object sender, EventArgs e)
        {
            var atuId = Convert.ToInt32(txtBoxFun.Text);

            if (Envio.Verifica == 1) { 
                await AtualizarCad(atuId); 
            }
            if(Envio.Verifica == 0)
            {
                await CriaCad(atuId);
            }
        }
        private async Task AtualizarCad(int ids)
        {
            var id = ids;
            var nome = txtBoxNome.Text;
            var cargo = txtBoxCargo.Text;
            var ende = txtBoxEnd.Text;
            var cep = txtBoxCep.Text;
            var datas = txtBoxDate.Text;
            var cpf = txtBoxCpf.Text;
            var email = txtBoxMail.Text;
            var tel = txtBoxTele.Text;
            var numero = txtBoxEndNum.Text;


            // Chama o método Puts da classe FunServices, passando o HttpRequestMessage
            FunServices funServices = new FunServices();
            try
            {
                //var response = await funServices;
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
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar funcionário: {ex.Message}");
            }
        }

        private async Task CriaCad(int ids)
        {
            FunCompleto novoFun = new FunCompleto
            {
                funId = ids,

            };
            var id = ids;
            var nome = txtBoxNome.Text;
            var cargo = txtBoxCargo.Text;
            var ende = txtBoxEnd.Text;
            var cep = txtBoxCep.Text;
            var datas = txtBoxDate.Text;
            var cpf = txtBoxCpf.Text;
            var email = txtBoxMail.Text;
            var tel = txtBoxTele.Text;
            var numero = txtBoxEndNum.Text;
            string senha = "";


            
            FunServices funServices = new FunServices();
            

            //try
            //{
            //    var response = await funServices.Post(request);
            //    foreach (Control control in this.Controls)
            //    {
            //        if (control != pnlItemFun)
            //        {
            //            control.Visible = false;
            //        }
            //    }

            //    pnlItemFun.Controls.Clear();
            //    AlfaPdv.Funcionario FuncionarioForm = new AlfaPdv.Funcionario();
            //    FuncionarioForm.TopLevel = false;
            //    FuncionarioForm.FormBorderStyle = FormBorderStyle.None;
            //    FuncionarioForm.Dock = DockStyle.Fill;
            //    pnlItemFun.Controls.Add(FuncionarioForm);
            //    FuncionarioForm.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Erro ao criar funcionário: {ex.Message}");
            //}
        }

        static void AdicionarCampos(Dictionary<string, object> campos, JObject objeto)
        {
            foreach (var campo in campos)
            {
                if (campo.Value != null)
                {
                    objeto[campo.Key] = JToken.FromObject(campo.Value);
                }
            }
        }
    }
}
