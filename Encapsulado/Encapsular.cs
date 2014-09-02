using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulado
{
    public class Encapsular
    {
        private String usuario;

        public String _Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private String clave;

        public String _Clave
        {
            get { return clave; }
            set { clave = value; }
        }
    }
}
