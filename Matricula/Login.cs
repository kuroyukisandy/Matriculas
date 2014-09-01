using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            F_Principal ventanaPrin = new F_Principal();
            this.Hide();
            ventanaPrin.Show(this);
        }
    }
}
