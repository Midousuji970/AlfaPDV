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
    public partial class ItemPag : Form
    {
        public ItemPag()
        {
            InitializeComponent();
            InitializeButton();
        }
        private void InitializeButton()
        {
            btnVolCadPag.Click += new EventHandler(btnVolCadPag_Click);
        }

        private void btnVolCadPag_Click(object sender, EventArgs e)
        {
            LoadCadProd();
        }

        private void LoadCadProd()
        {
            foreach (Control control in this.Controls)
            {
                if (control != pnlItemPag)
                {
                    control.Visible = false;
                }
            }

            pnlItemPag.Controls.Clear();
            AlfaPdv.Paga PagamentoForm = new AlfaPdv.Paga();
            PagamentoForm.TopLevel = false;
            PagamentoForm.FormBorderStyle = FormBorderStyle.None;
            PagamentoForm.Dock = DockStyle.Fill;
            pnlItemPag.Controls.Add(PagamentoForm);
            PagamentoForm.Show();


        }
    }
}
