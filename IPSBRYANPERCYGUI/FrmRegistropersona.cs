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

namespace IPSBRYANPERCYGUI
{
    public partial class FrmRegistropersona : Form
    {
        LiquidacionCuotaModeradoraService LiquidacionCuotaModeradoraService;
        public FrmRegistropersona()
        {
            InitializeComponent();
            LiquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }



        private LiquidacionCuotaModeradoraService MapearTextoLiquidacion()
        {
            if (combotipoafiliacion.Equals("Contributivo"))
            {

                LiquidacionCuotaModeradora liquidacion = new LiquidacionCuotaModeradoraContributivo();
                liquidacion.TipoAfiliacion = MapearLiquidacion(combotipoafiliacion.Text);
                liquidacion.NumeroLiquidacion = Txtnliquidacion.Text;
                liquidacion.IdentificacionPaciente = Txtidentificacion.Text;
                liquidacion.SalarioPaciente = Double.Parse(Txtsalariopaciente.Text);
                liquidacion.ValorServicio = Double.Parse(Txtvalorservicio.Text);
                txtsalario.Text = liquidacion.ToString();
                return liquidacion;
            }
            else {
                LiquidacionCuotaModeradora liquidacion = new LiquidacionCuotaModeradoraSubsidiado();
                liquidacion.TipoAfiliacion = MapearLiquidacion(combotipoafiliacion.Text);
                liquidacion.NumeroLiquidacion = Txtnliquidacion.Text;
                liquidacion.IdentificacionPaciente = Txtidentificacion.Text;
                liquidacion.SalarioPaciente = Double.Parse(Txtsalariopaciente.Text);
                liquidacion.ValorServicio = Double.Parse(Txtvalorservicio.Text);
                txtsalario.Text = liquidacion.ToString();
                return liquidacion;
            }
           
            
        }

        private string MapearLiquidacion(string liquidacion)
        {
            if (liquidacion.Equals("Contributivo"))
            {
                return "C";
            }
            else
            {
                return "S";
            }
        }
    }
}
