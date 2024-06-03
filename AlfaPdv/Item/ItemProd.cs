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
    public partial class ItemProd : Form
    {
        public ItemProd()
        {
            InitializeComponent();
            InitializeButton();
        }
        private void InitializeButton()
        {
            btnVolProd.Click += new EventHandler(btnVolProd_Click);
        }

        private void btnVolProd_Click(object sender, EventArgs e)
        {
            LoadCadProd();
        }

        private void LoadCadProd()
        {
            foreach(Control control in this.Controls ){
                if(control != pnlProd)
                {
                    control.Visible = false;
                }
            }

            pnlProd.Controls.Clear();
            AlfaPdv.Produto ProdutoForm = new AlfaPdv.Produto();
            ProdutoForm.TopLevel = false;
            ProdutoForm.FormBorderStyle = FormBorderStyle.None;
            ProdutoForm.Dock = DockStyle.Fill;
            pnlProd.Controls.Add( ProdutoForm );
            ProdutoForm.Show();


        }
    }
}
