using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumidorR
{
    public partial class Consumidor : System.Web.UI.Page
    {
        ServiceReference1.WebService1SoapClient Servicio = new ServiceReference1.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSumar_Click(object sender, EventArgs e)
        {

            LblResultado.Text = Servicio.Suma(Convert.ToInt32(txtNumero1.Text), Convert.ToInt32(txtNumero2.Text)).ToString();
        }

        protected void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            LblResultado.Text = Servicio.Multiplicación(Convert.ToInt32(txtNumero1.Text), Convert.ToInt32(txtNumero2.Text)).ToString();
        }

        protected void BtnResta_Click(object sender, EventArgs e)
        {
            LblResultado.Text = Servicio.Resta(Convert.ToInt32(txtNumero1.Text), Convert.ToInt32(txtNumero2.Text)).ToString();
        }

        protected void BtnDivision_Click(object sender, EventArgs e)
        {
            LblResultado.Text = Servicio.División(Convert.ToInt32(txtNumero1.Text), Convert.ToInt32(txtNumero2.Text)).ToString();
        }
    }
}