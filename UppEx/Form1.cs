using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using MetroFramework.Forms;

namespace UppEx
{
    public partial class UppEx : MetroForm
    {
        public UppEx()
        {
            InitializeComponent();
        }

        private void UppEx_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        
        private void btnListarPedido_Click(object sender, EventArgs e)
        {
            Servicio miServicio = new Servicio();
            ConsultarPedido parametros = new ConsultarPedido();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);

            string resultados = miServicio.llamarServicio(body);
            var canciones = ser.Deserialize<List<ResultsConsultarPedido>>(resultados);

            dgvListarPedido.DataSource = null;
            dgvListarPedido.DataSource = canciones;
        }

        private void btnRegistrarUsuario_Click_1(object sender, EventArgs e)
        {
            string clave = txtRUClave.Text;
            string nombre = txtRUNombre.Text;
            string correo = txtRUCorreo.Text;
            string direccion = txtRUDireccion.Text;
            string telefono = txtRUTelefono.Text;

            Servicio miServicio = new Servicio();
            InsertarUsuario parametros = new InsertarUsuario(clave, nombre, correo, direccion, telefono);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);

            string resultados = miServicio.llamarServicio(body);
            char cont = ':';

            string[] mas = resultados.Split(cont);
            string masa = mas[1];
            char cant = '"';
            string[] menos = masa.Split(cant);
            MessageBox.Show(menos[1]);
        }

        private void btnRegistrarPedido_Click_1(object sender, EventArgs e)
        {
            string IdPedido = txtRPIdPedido.Text;
            string Peso = txtRPPeso.Text;
            string Dimensiones = txtRPDimensiones.Text;
            string Origen = txtRPOrigen.Text;
            string Destino = txtRPDestino.Text;
            string FechaEntrega = txtRPFechaEntrega.Text;
            string Tipo = txtRPTipo.Text;
            string Costo = txtRPCosto.Text;

            Servicio miServicio = new Servicio();
            InsertarPedido parametros = new InsertarPedido(Peso, Dimensiones, Origen, Destino, Tipo, FechaEntrega, Costo, IdPedido);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);

            string resultados = miServicio.llamarServicio(body);
            char cont = ':';

            string[] mas = resultados.Split(cont);
            string masa = mas[1];
            char cant = '"';
            string[] menos = masa.Split(cant);
            MessageBox.Show(menos[1]);
        }

        private void btnConsultarPedido_Click_1(object sender, EventArgs e)
        {
           /* string descripcion = txtCPDescripcion.Text;
            string tipo = txtCPTipo.Text;
            string idusuario = txtCPIdUsuario.Text;
            string idpedido = txtCPIdPedido.Text;

            Servicio miServicio = new Servicio();
            InsertarMovimiento parametros = new InsertarMovimiento(descripcion, tipo, idusuario, idpedido);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);

            string resultados = miServicio.llamarServicio(body);
            char cont = ':';

            string[] mas = resultados.Split(cont);
            string masa = mas[1];
            char cant = '"';
            string[] menos = masa.Split(cant);
            MessageBox.Show(menos[1]);*/
        }
        
        private void btnRegistarPedido_Click_1(object sender, EventArgs e)
        {
            string aux = txtRegistrarMovimiento.Text;
            Servicio miServicio = new Servicio();
            ConsultarMovimientos parametros = new ConsultarMovimientos(aux);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);

            string resultados = miServicio.llamarServicio(body);
            var canciones = ser.Deserialize<List<ResultsConsultarMovimientos>>(resultados);

            dgvConsultarMovimiento.DataSource = null;
            dgvConsultarMovimiento.DataSource = canciones;
        }

        private void txtRegistrarMovimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtRPIdPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtRUClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtRUNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRPTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
