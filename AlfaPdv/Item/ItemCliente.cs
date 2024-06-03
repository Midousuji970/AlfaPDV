using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlfaPdv.Item
{
    public partial class ItemCli : Form
    {
        public ItemCli()
        {
            InitializeComponent();
            InitializeButton();
        }
        private void InitializeButton()
        {
            btnVolCadCli.Click += new EventHandler(btnVolCadCli_Click);
        }

        private void btnVolCadCli_Click(object sender, EventArgs e)
        {
            LoadCadProd();
        }

        private void LoadCadProd()
        {
            foreach (Control control in this.Controls)
            {
                if (control != pnlItemCli)
                {
                    control.Visible = false;
                }
            }

            pnlItemCli.Controls.Clear();
            AlfaPdv.Cliente ClienteForm = new AlfaPdv.Cliente();
            ClienteForm.TopLevel = false;
            ClienteForm.FormBorderStyle = FormBorderStyle.None;
            ClienteForm.Dock = DockStyle.Fill;
            pnlItemCli.Controls.Add(ClienteForm);
            ClienteForm.Show();


        }

    }
}
