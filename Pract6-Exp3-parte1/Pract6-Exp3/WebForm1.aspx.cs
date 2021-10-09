using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Pract6_Exp3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString = "Data Source = LAPTOP-B9OTGNO1\\SQLEXPRESS;" +
        "Initial Catalog = VENTAS; Integrated Security = SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            string insertSQL = "INSERT INTO clientes VALUES(" +
            txtCodigo.Text + ",'" + txtNombres.Text + "', '" +
            txtDireccion.Text + "', '" + txtTelefono.Text + "', '" +
            txtMail.Text + "', " + txtEdad.Text + ")";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(insertSQL, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                lblResult.Text = "Cliente registrado con éxito";
                con.Close();
                txtCodigo.Text = "";
                txtNombres.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtMail.Text = "";
                txtEdad.Text = "";
            }
            catch (Exception err)
            {

                lblResult.Text = "Error al registrar el cliente";
                lblResult.Text += err.Message;
            }
        }
    }
}
      
