using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPSGUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            abrirformve(new Frmcasa());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btoningresar_Click(object sender, EventArgs e)
        {
            abrirformve(new FrmRegistrar()); 
            
        }

        private void btonconsulta_Click(object sender, EventArgs e)
        {
            abrirformve(new Frmconsultar());
        }
        private void abrirformve(Form f)
        {

            if (this.panelcontenedor.Controls.Count > 0)
            {

                this.panelcontenedor.Controls.RemoveAt(0);
            }

            f.TopLevel = false;
            this.panelcontenedor.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void BtonHome_Click(object sender, EventArgs e)
        {
            abrirformve(new Frmcasa());
        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
