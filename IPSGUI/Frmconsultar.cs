using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;
namespace IPSGUI
{
    public partial class Frmconsultar : Form
    {
        LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
        public Frmconsultar()
        {
            InitializeComponent();
            LlenarTabla();
        }

        private void LlenarTabla()
        {
            DgvLiquidacion.DataSource = null;
            DgvLiquidacion.DataSource = LiquidacionCuotaModeradoraService.ConsultarTodos();
        }
        private void CargarContributivo()
        {
            DgvLiquidacion.DataSource = null;
            DgvLiquidacion.DataSource = LiquidacionCuotaModeradoraService.ListarContributivo().ToList();
            TxtContributivo.Text = service.TotalizarContributivo().ToString();
            TxtSubsidiado.Text = "";
            LimpiarTxt();


        }
        private void CargarSubsidiado()
        {
            DgvLiquidacion.DataSource = null;
            DgvLiquidacion.DataSource = LiquidacionCuotaModeradoraService.ListarSubsidiado().ToList();
            TxtSubsidiado.Text = service.TotalizarSubsidiado().ToString();
            TxtContributivo.Text = "";
            LimpiarTxt();
        }
        private void CargarTodos()
        {
            LlenarTabla();
            TxtTotal.Text = service.TotalizarTodos().ToString();
            TxtContributivo.Text = service.TotalizarContributivo().ToString();
            TxtSubsidiado.Text = service.TotalizarSubsidiado().ToString();

        }
        
        private void LimpiarTxt()
        {
            TxtTotal.Text = "";

        }
        
        private void PrepararDatos()
        {
            if (CmbTipoAfiliacion.Text.Equals("Todos"))
            {
                CargarTodos();
            }

            if (CmbTipoAfiliacion.Text.Equals("Subsidiado"))
            {
                CargarSubsidiado();

            }
            if (CmbTipoAfiliacion.Text.Equals("Contributivo"))
            {
                CargarContributivo();
            }
        }

    }
}
