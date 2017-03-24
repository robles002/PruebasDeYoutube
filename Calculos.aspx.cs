using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calculos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCalcular_Click(object sender, EventArgs e)
    {
      //  clsCalculos calculos = new clsCalculos(0, 0, 0);

        clsCalculos calculos = new clsCalculos();


        if (rbOperacion.SelectedValue == "1")
        {
            txtResultado.Text = calculos.Suma(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text)) + "";
        }
        else if (rbOperacion.SelectedValue == "2")
        {
            txtResultado.Text = calculos.Resta(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text)) + "";
        }
        else if (rbOperacion.SelectedValue == "3")
        {
            txtResultado.Text = calculos.Producto(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text)) + "";
        }
    }
}
