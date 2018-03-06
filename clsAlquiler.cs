using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class clsAlquiler
    {
        private int _IdAlquiler;

        public int IdAlquiler
        {
            get { return _IdAlquiler; }
            set { _IdAlquiler = value; }
        }

        private DateTime _FechaAlquiler;

        public DateTime FechaAlquiler
        {
            get { return _FechaAlquiler; }
            set { _FechaAlquiler = value; }
        }

        private string _Observacion;

        public string Observacion
        {
            get { return _Observacion; }
            set { _Observacion = value; }
        }

        private clsCliente _IdCliente;

        public clsCliente IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        private clsUsuario _IdUsuario;

        public clsUsuario IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        public clsAlquiler(int argIdAlquiler, DateTime argFechaAlquiler, string argObservacion,
                           clsCliente argIdCliente, clsUsuario argIdUsuario) 
        {
            IdAlquiler = argIdAlquiler;
            FechaAlquiler = argFechaAlquiler;
            Observacion = argObservacion;
            IdCliente = argIdCliente;
            IdUsuario = argIdUsuario;
        }
        public clsAlquiler(DateTime argFechaAlquiler, string argObservacion,
                           clsCliente argIdCliente, clsUsuario argIdUsuario)
        {
            FechaAlquiler = argFechaAlquiler;
            Observacion = argObservacion;
            IdCliente = argIdCliente;
            IdUsuario = argIdUsuario;
        }

    }
}
