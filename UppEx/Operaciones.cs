namespace UppEx
{
    class InsertarUsuario
    {
        public string action { get; set; }

        public string clave { get; set; }

        public string nombre { get; set; }

        public string correo { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }

        public InsertarUsuario(string clavec, string nombrec, string correoc, string direccionc, string telefonoc)
        {
            action = "insertarUsuario";
            clave = clavec;
            nombre = nombrec;
            correo = correoc;
            direccion = direccionc;
            telefono = telefonoc;
        }
    }

    class InsertarPedido
    {
        public string action { get; set; }

        public string peso { get; set; }

        public string dimensiones { get; set; }

        public string origen { get; set; }

        public string destino { get; set; }

        public string tipo { get; set; }

        public string fechaEntrega { get; set; }

        public string costo { get; set; }

        public string idusuario { get; set; }

        public InsertarPedido(string pesoc, string dimensionesc, string origenc,string destinoc,string tipoc,string fechaEntregac, string costoc, string idusuarioc)
        {
            action = "insertarPedido";
            peso = pesoc;
            dimensiones = dimensionesc;
            origen = origenc;
            destino = destinoc;
            tipo = tipoc;
            fechaEntrega = fechaEntregac;
            costo = costoc;
            idusuario = idusuarioc;
        }
    }

    class InsertarMovimiento
    {
        public string action { get; set; }

        public string descripcion { get; set; }

        public string tipo { get; set; }

        public string idusuario { get; set; }

        public string idpedido { get; set; }
        
        public InsertarMovimiento(string descripcionc, string tipoc, string idusuarioc, string idpedidoc)
        {
            action = "insertarMovimiento";
            descripcion = descripcionc;
            tipo = tipoc;
            idusuario = idpedidoc;
            idpedido = idpedidoc;
        }
    }

    class ConsultarMovimientos
    {
        public string action { get; set; }

        public string id { get; set; }

        public ConsultarMovimientos(string idc)
        {
            action = "consultarMovimientos";
            id = idc;
        }
    }
    
    class ResultsConsultarMovimientos
    {
        public string hora { get; set; }

        public string descripcion { get; set; }
    }

    class ConsultarPedido
    {
        public string action { get; set; }

        public ConsultarPedido()
        {
            action = "ConsultarPedido";
        }
    }

    class ResultsConsultarPedido
    {
        public int idpedido { get; set; }

        public string horaPedido { get; set; }

        public string fechaPedido { get; set; }

        public int idusuario { get; set; }

        public string idpaquete { get; set; }
    }
}
