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
    public partial class FrmRegistrar : Form
    {
        LiquidacionCuotaModeradora liquidacion;
        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private LiquidacionCuotaModeradora MapearLiquidacion()
        {
            
            if (CmbTipoAfiliacion.Text.Equals("Contributivo"))
            {
                liquidacion = new LiquidacionCuotaModeradoraContributivo();
                liquidacion.NumeroLiquidacion = TxtNumeroLiquidacion.Text;
                liquidacion.FechaLiquidacion = DtpFechaLiquidacion.Value.Date;
                liquidacion.Identificacion = TxtIdentificacion.Text;
                liquidacion.TipoAfiliacion = CmbTipoAfiliacion.Text;
                liquidacion.SalarioDevengado = double.Parse(TxtSalarioDevengado.Text);
                liquidacion.ValorServicioHospitalizacion = double.Parse(TxtValorHospitalizacion.Text);
                return liquidacion;
            }
            if (CmbTipoAfiliacion.Text.Equals("Subsidiado"))
            {
                liquidacion = new LiquidacionCuotaModeradoraSubsidiado();
                liquidacion.NumeroLiquidacion = TxtNumeroLiquidacion.Text;
                liquidacion.FechaLiquidacion = DtpFechaLiquidacion.Value.Date;
                liquidacion.Identificacion = TxtIdentificacion.Text;
                liquidacion.TipoAfiliacion = CmbTipoAfiliacion.Text;
                liquidacion.SalarioDevengado = double.Parse(TxtSalarioDevengado.Text);
                liquidacion.ValorServicioHospitalizacion = double.Parse(TxtValorHospitalizacion.Text);
                return liquidacion;
            }
            return null;
        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btonguardar_Click(object sender, EventArgs e)
        {
            LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
            LiquidacionCuotaModeradora cuotaModeradora = MapearLiquidacion();
            cuotaModeradora.CalcularTarifa();
            string mesanje = service.Guardar(cuotaModeradora);
            MessageBox.Show(mesanje, "MENSAJE GUARDADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("ESTA SEGURO DE ELIMINAR EL REGISTRO", "MENSAJE DE ELIMINACIÓN", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
                string identificacion = TxtIdentificacion.Text;
                string mensaje2 = liquidacionCuotaModeradoraService.Eliminar(identificacion);
                MessageBox.Show(mensaje2);
                Limpiar();

            }
        }
        public void Limpiar()
        {
            TxtNumeroLiquidacion.Text = "";
            DtpFechaLiquidacion.Text = "";
            TxtIdentificacion.Text = "";
            CmbTipoAfiliacion.Text = "";
            TxtSalarioDevengado.Text = "";
            TxtValorHospitalizacion.Text = "";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }

   

}
