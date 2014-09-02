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

            this.DialogResult = DialogResult.OK;
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
