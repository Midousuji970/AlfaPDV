using AlfaPdv.Classes;
using AlfaPdv.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlfaPdv
{
    public partial class ALFAPDV : Form
    {
        public ALFAPDV()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtB1.Text;
                int id = Convert.ToInt32(codigo);
                string senha = txtB3.Text;

                FunServices funServices = new FunServices();
                ChamarFun existeFun = await funServices.Integracao(id);

                string senhas = existeFun.Senha;

                if (senha != senhas)
                {
                    MessageBox.Show($"Senha Incorreta");
                }
                else
                {
                    Inicio formInicio = new Inicio();
                    formInicio.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
