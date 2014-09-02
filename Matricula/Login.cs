using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Datos;
using Encapsulado;

namespace Matricula
{
    public partial class F_matricula : Form
    {
        public F_matricula()
        {
            InitializeComponent();
        }

        private void B_ingresar_Click(object sender, EventArgs e)
        {
            //String usuario = 
            //String clave = 
            Encapsular encDatos = new Encapsular();
            Logeo objLogin = new Logeo();
            encDatos._Usuario=TB_usuario.Text;
            encDatos._Clave = TB_clave.Text;
            if(objLogin.login(encDatos)){
                this.DialogResult = DialogResult.OK;
            }else{
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
